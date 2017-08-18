namespace Behavior
{
  public delegate bool ConditionalDelegate(); 

  public class Conditional : Task
  {
    public ConditionalDelegate Condition
    {
      get;
      private set;
    }

    public override Status Execute()
    {
      if (true == Condition())
      {
        return Status.SUCCEEDED;
      }

      return Status.FAILED;
    }
  }
}
