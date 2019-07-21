from matplotlib import pyplot
from math import cos, sin, atan
import numpy as np

class Neuron():
    def __init__(self, x, y, is_bias=False):
        self.x = x
        self.y = y
        self.is_bias = is_bias

    def draw(self, neuron_radius):
        if not self.is_bias:
            neuron = pyplot.Circle((self.x, self.y), radius=neuron_radius, fill=False)
        else:
            neuron = pyplot.Polygon(
                [[self.x - neuron_radius, self.y - neuron_radius], [self.x - neuron_radius, self.y + neuron_radius],
                 [self.x + neuron_radius, self.y + neuron_radius], [self.x + neuron_radius, self.y - neuron_radius]],
                fill=False)

        pyplot.gca().add_patch(neuron)

class Layer():
    def __init__(self, network, number_of_neurons, number_of_neurons_in_widest_layer, weights, end=False):
        self.vertical_distance_between_layers = 7
        self.horizontal_distance_between_neurons = 6
        self.neuron_radius = 0.5
        self.number_of_neurons_in_widest_layer = number_of_neurons_in_widest_layer
        self.previous_layer = self.__get_previous_layer(network)
        self.y = self.__calculate_layer_y_position()
        self.neurons = self.__intialise_neurons(number_of_neurons, end)
        self.weights = weights
        self.i = 0
    def __intialise_neurons(self, number_of_neurons, end):
        neurons = []
        x = self.__calculate_left_margin_so_layer_is_centered(number_of_neurons)
        for iteration in range(number_of_neurons):
            neuron = Neuron(x, self.y)
            neurons.append(neuron)
            x += self.horizontal_distance_between_neurons
        if not end:
            neuron = Neuron(x, self.y, True)
            neurons.append(neuron)
            x += self.horizontal_distance_between_neurons
        return neurons

    def __calculate_left_margin_so_layer_is_centered(self, number_of_neurons):
        return self.horizontal_distance_between_neurons * (self.number_of_neurons_in_widest_layer - number_of_neurons) / 2

    def __calculate_layer_y_position(self):
        if self.previous_layer:
            return self.previous_layer.y + self.vertical_distance_between_layers
        else:
            return 0

    def __get_previous_layer(self, network):
        if len(network.layers) > 0:
            return network.layers[-1]
        else:
            return None

    def __line_between_two_neurons(self, neuron1, neuron2, label='w'):
        global i
        if (neuron1.is_bias):
            return
        angle = atan((neuron2.x - neuron1.x) / float(neuron2.y - neuron1.y))
        x_adjustment = self.neuron_radius * sin(angle)
        y_adjustment = self.neuron_radius * cos(angle)
        line = pyplot.Line2D((neuron1.x - x_adjustment, neuron2.x + x_adjustment), (neuron1.y - y_adjustment, neuron2.y + y_adjustment))
        l1 = np.array([neuron2.x + x_adjustment, neuron2.y + y_adjustment])
        # print(trans_angle)
        # pyplot.text(neuron2.x + 0.5*(neuron2.x - neuron1.x), (neuron2.y + neuron1.y)/2, 'w', fontsize=16)
        dist_x = 0
        dist_y = 3
        if neuron1.x > neuron2.x:
            dist_x = 0.2*abs(neuron2.x - neuron1.x)
        elif neuron1.x < neuron2.x:
            dist_x = -0.3*abs(neuron2.x - neuron1.x)
            dist_y -= 1
        else:
            dist_y += 1
            dist_x = -1.3
        pyplot.text(neuron2.x + dist_x, neuron2.y + dist_y, self.weights[self.i], fontsize=16)
        self.i += 1

        pyplot.gca().add_line(line)

    def draw(self, layerType=0):
        for neuron in self.neurons:
            neuron.draw( self.neuron_radius )
            if self.previous_layer:
                for previous_layer_neuron in self.previous_layer.neurons:
                    self.__line_between_two_neurons(neuron, previous_layer_neuron)
        # write Text
        x_text = (self.number_of_neurons_in_widest_layer + 0.4) * self.horizontal_distance_between_neurons
        if layerType == 0:
            pyplot.text(x_text, self.y, 'Input Layer', fontsize = 12)
        elif layerType == -1:
            pyplot.text(x_text, self.y, 'Output Layer', fontsize = 12)
        else:
            pyplot.text(x_text, self.y, 'Hidden Layer '+str(layerType), fontsize = 12)

class NeuralNetwork():
    def __init__(self, number_of_neurons_in_widest_layer):
        self.number_of_neurons_in_widest_layer = number_of_neurons_in_widest_layer
        self.layers = []
        self.layertype = 0

    def add_layer(self, number_of_neurons, is_end, weights):
        layer = Layer(self, number_of_neurons, self.number_of_neurons_in_widest_layer, weights, is_end)
        self.layers.append(layer)

    def draw(self):
        pyplot.figure()
        for i in range( len(self.layers) ):
            layer = self.layers[i]
            if i == len(self.layers)-1:
                i = -1
            layer.draw( i )
        pyplot.axis('scaled')
        pyplot.axis('off')
        pyplot.title( 'Neural Network architecture', fontsize=15 )
        pyplot.show()

class DrawNN():
    def __init__(self, input_dim, weights, hidden_units, output_dim):
        self.input_dim = input_dim
        self.weights = weights
        self.hidden_units = hidden_units
        self.output_dim = output_dim
        self.neural_network = [self.input_dim] + self.hidden_units + [self.output_dim]


    def draw( self ):
        widest_layer = max( self.neural_network)
        network = NeuralNetwork( widest_layer)
        total_done = 0
        for i, l in enumerate(self.neural_network):
            weigths_l = []
            if i > 0:
                end = (self.neural_network[i - 1] + 1)*self.neural_network[i]
                weigths_l = self.weights[total_done: total_done + end]
                total_done += end
            network.add_layer(l, i==(len(self.neural_network) - 1), weigths_l)
        network.draw()


if __name__ == '__main__':
    filename = "./weights.txt"
    with open(filename) as file:
        weights = next(file)
        weights = [int(w) if int(w) == 1 else -1 for w in weights.split(' ')]
        hidden_units = next(file)
        hidden_units = [int(h) for h in hidden_units.split(' ')]
        input_dim = int(next(file))
        output_dim = int(next(file))
    network = DrawNN(input_dim, weights, hidden_units, output_dim)
    network.draw()