using yWorks.Graph;

namespace yFilesProblemWithNet6
{
    internal class YFilesInitializer
    {
        internal void InitializeYFiles()
        {
            // I didn't bother to put my license here, but in my production system, I have enbedded the license.
            var graph = new DefaultGraph();
            graph.CreateNode(tag: "Node1");
        }
    }
}
