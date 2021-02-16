using System.Collections.Generic;
using System.Text;

namespace GenericsExcercise
{
    public class Box<T>
    {
        public Box()
        {
            this.Data = new List<T>();
        }

        public List<T> Data { get; set; }

        public void Swap(int index1, int index2)
        {
            T temp = this.Data[index1];
            this.Data[index1] = this.Data[index2];
            this.Data[index2] = temp;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var data in this.Data)
            {
                sb.AppendLine($"{data.GetType().FullName}: {data}");
            }
            return sb.ToString();
        }
    }
}
