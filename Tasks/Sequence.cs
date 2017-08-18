namespace Behavior
{
  public class Sequence : Task
  {
    /**
     * Runs each sub-task in sequence until one fails.
     */
    public override Status Execute()
    {
      // TODO: This might cause a performance hit
      foreach (var Child in Children)
      {
        var status = Child.Execute();

        if (Status.SUCCEEDED != status)
        {
          return status;
        }
      }

      return Status.SUCCEEDED;
    }
  }
}
