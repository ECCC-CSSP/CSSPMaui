namespace CSSPModels;

[NotMapped]
public partial class Vector
{
    public Node StartNode { get; set; } = new Node();
    public Node EndNode { get; set; } = new Node();

    public Vector()
    {

    }
}

