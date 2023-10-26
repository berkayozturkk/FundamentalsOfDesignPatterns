using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.Business;

public class MyCollection : IEnumerable<int>
{
    private List<int> items = new List<int>();

    public void Add(int item)
    {
        items.Add(item);
    }

    public IEnumerator<int> GetEnumerator()
    {
        return items.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
