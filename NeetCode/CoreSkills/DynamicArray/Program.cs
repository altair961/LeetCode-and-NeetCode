namespace DynamicArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ["Array", 4, "pushback", 1, "set", 0, 0, "pushback", 2, "get", 0, "get", 1,
            // "getCapacity", "popback"]
            // your    [null,null,null,null,0,2,2,2]
            // correct [null,null,null,null,0,2,4,2]

            var dynamicArr = new DynamicArray(4);       // null
            dynamicArr.PushBack(1);                     // null
            dynamicArr.Set(0, 0);                       // null
            dynamicArr.PushBack(2);                     // null
            var getRes0 = dynamicArr.Get(0);            // 0
            var getRes1 = dynamicArr.Get(1);            // 2 
            var capacity1 = dynamicArr.GetCapacity();   // 2 sh be 4
            var popBackRes1 = dynamicArr.PopBack();     // 2

            /*
            // ["Array", 1, "pushback", 1, "getCapacity", "pushback", 2, "getCapacity"]
            // your    [null,null,1,null,1]
            // correct [null,null,1,null,2]

            var dynamicArr = new DynamicArray(1);       // null
            dynamicArr.PushBack(1);                     // null
            var capacity1 = dynamicArr.GetCapacity();   // 1
            dynamicArr.PushBack(2);                     // null
            var capacity2 = dynamicArr.GetCapacity();   // 2
             */
        }
    }
}
