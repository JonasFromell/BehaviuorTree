namespace Behavior
{
  public delegate Status ActionDelegate();

  public class Action : Task
  {
    public ActionDelegate Run
    {
      get;
      private set;
    }

    public override Status Execute()
    {
      if (null != Run)
      {
        return Run();
      }

      return Status.FAILED;
    }
  }
}
