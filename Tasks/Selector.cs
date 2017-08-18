using System.Collections.Generic;

namespace Behavior
{
  public class Selector : Task
  {
    /**
     * Loops through each sub-task until one task has suceeded
     */
    public override Status Execute()
    {
      // TODO: This might cause a performance hit
      foreach (var Child in Children)
      {
        var status = Child.Execute();

        if (Status.FAILED != status)
        {
          return status;
        }
      }

      return Status.FAILED;
    }
  }
}
