using System.Collections;

namespace Project{
    class List2 : IEnumerable
    {
        List<int> list=new List<int>();
        public void Add(int value)=>list.Add(value);

        // public IEnumerator GetEnumerator()
        // {
        //     return new IListNumerator(list);
        // }

        public IEnumerator GetEnumerator() => list.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    class IListNumerator : IEnumerator{
        public int index;
        List<int> list;

        public IListNumerator(List<int> _list){
            list=_list;
            index=-1;
        }
        public object Current=>list[index];

        public bool MoveNext(){
            index++;
            return index<list.Count;
        }

        public void Reset()=>index=-1;
    }

}