using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    internal struct Item
    {
        public string Name;
        public string Value;
    };

    public class MyCollection
    {
        private List<Item> _items = new List<Item>();

        // default constructor
        public MyCollection()
        {
            //List<MyItem> _items = new List<MyItem>();
        }

        // property to return the lenght of the collection
        public int Count
        {
            get
            {
                return _items.Count;
            }
        }

        // property to return an array of unique names
        public string[] Names
        {
            get
            {
                List<string> uniqueNames = new List<string>();
                foreach (var i in _items)
                {
                    if (!uniqueNames.Contains(i.Name))
                    {
                        uniqueNames.Add(i.Name);
                    }
                }
                return uniqueNames.ToArray();
            }
        }

        // add item to collection
        public void Add(string name, string value)
        {
            Item item = new Item();

            if (name != "")
            {
                item.Name = name;
                item.Value = value;
                _items.Add(item);
            }
        }

        // remove item from collection
        public void Remove(string name)
        {
            for (int i = 0; i < _items.Count; i++)
            {
                if (_items[i].Name == name)
                {
                     _items.RemoveAt(i);
                     --i;
                }
            }
        }

        // clear the collection
        public void Clear()
        {
            _items.Clear();
        }

        // check if collection contains an item with a specified name
        public bool ContainsName(string name)
        {
            for (int i = 0; i < _items.Count; i++)
            {
                if (_items[i].Name == name)
                {
                    return true;
                }
            }
            return false;
        }

        // get the value for a specified name
        // if multiple value, get all separated by a comma
        public string GetValue(string name)
        {
            List<string> values = new List<string>();
            foreach (var i in _items)
            {
                if (i.Name == name)
                {
                    values.Add(i.Value);
                }
            }

            if (values.Count > 0)
            {
                return string.Join(",", values.ToArray());
            }

            return null;
        }

        // get all the values for a specified name
        public string[] GetValues(string name)
        {
            List<string> values = new List<string>();
            foreach (var i in _items)
            {
                if (i.Name == name)
                {
                    values.Add(i.Value);
                }
            }

            return values.ToArray();
        }

        // set the value with a specified name
        public void SetValue(string name, string value)
        {
            for (int i = 0; i < _items.Count; i++)
            {
                if (_items[i].Name == name)
                {
                    Item item = new Item();
                    item.Name = name;
                    item.Value = value;
                    _items[i] = item;
                }
            }
        }

        // overriten tostring method
        // consumer can print all the items from the collection
        public override string ToString()
        {
            List<string> nameValues = new List<string>();
            foreach (var i in _items)
            {
                nameValues.Add(i.Name);
                nameValues.Add(": ");
                nameValues.Add(i.Value);
                nameValues.Add("\n");
            }
            return String.Join("",nameValues.ToArray());
        }

    }// end MyCollection class

    //class TestCollection
    //{
    //    static void Main(string[] args)
    //    {
    //        MyCollection mycollection = new MyCollection();
    //        mycollection.Add("Arex", "Great");
    //        mycollection.Add("Boris", "NotSoGreat");
    //        mycollection.Add("Arex", "AllmostGreat");
    //        mycollection.Add("Arexx", "OKGreat");
    //        mycollection.SetValue("Arex", "boooo");

    //        System.Diagnostics.Debug.WriteLine(mycollection.ToString());

    //    }
    //}
}
