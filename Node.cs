using System;
using System.Collections.Generic;

namespace Behavior
{
  public abstract class Node<T>
  {
    /**
     * The parent of this node in the tree.
     */
    public T Parent;

    public List<T> Children
    {
      get
      {
        return _children;
      }
    }

    private List<T> _children;

    protected void Add(T child)
    {
      _children.Add(child);
    }

    protected T Get(int index)
    {
      return _children[index];
    }
  }
}
