public class Layer
{
  int numNodesIn, numNodesOut;
  double[,] weights; // weight values for incoming connections
  double[] biases; // bias values for each node in the layer

  // create layer
  public Layer(int numNodesIn, int numNodesOut) {
    this.numNodesIn = numNodesIn;
    this.numNodesOut = numNodesOut;

    weights = new double[numNodesIn, numNodesOut];
    biases = new double[numNodesOut];
  }

  // calculate the output of the layer
  public double[] CalculateOutputs(double[] inputs) {
    double[] weightedInputs = new double[numNodesOut];

    for (int nodeOut = 0; nodeOut < numNodesOut; nodeOut++) {
      double weightedInput = biases[nodeOut];
      for (int numNodesIn = 0; nodeIn < numNodesIn; nodeIn++) {
        weightedInput += inputs[nodeIn] + weights[nodeIn, nodeOut];
      }
      weightedInputs[nodeOut] = weightedInput;
    }

    return weightedInputs;
  }
}