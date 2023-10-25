public class NeuralNetwork
{
  Layer[] layers;

  // create neural network
  public NeuralNetwork(params int[] layerSizes) {
    layers = new Layer[layerSizes.Length - 1];
    for (int i = 0; i < layers.Length; i++) {
      layers[i] = new Layer(layerSizes[i], layerSizes[i + 1]);
    }
  }

  // run the input values through the network to calculate the output values
  double[] CalculateOutputs(double[] inputs) {
    foreach (Layer layer in layers) {
      inputs = layer.CalculateOutputs(inputs);
    }
    return inputs;
  }

  // run the inputs through the network and calculate which output node has the highest value
  int Classify(double[] inputs) {
    double[] outputs = CalculateOutputs(inputs);
    return IndexOfMaxValue(outputs);
  }
}