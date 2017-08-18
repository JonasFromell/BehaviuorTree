using System;
using System.Collections.Generic;

namespace Behavior
{
  public abstract class Task : Node<Task>
  {
    /**
     * Executes the action and returns the result.
     */
    public abstract Status Execute();
  }
}
