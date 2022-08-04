namespace FoodieCorner.ConsoleApp
{
    public class SNode
    {
        public SNode Next;
        public object Value;
    }
    public class SLL
    {
        public SNode head;
        public SNode current;
        public int Count;

        public SLL()
        {
            head = new SNode();
            current = head;
        }
        public void AddLast(object data)
        {
            SNode newNode = new SNode();
            newNode.Value = data;
            current.Next = newNode;
            current = newNode;
            Count++;
        }
        public void AddStart(object data)
        {
            SNode newNode = new SNode(); 
            newNode.Value = data;
            newNode.Next = head.Next;
            head.Next = newNode;
            Count++;
        }
        public void DelStart()
        {
            if (Count > 0)
            {
                head.Next = head.Next.Next;
                Count--;
            }
            else
            {
                Console.WriteLine("  The LinkedList is Empty");
            }
        }
        public void PrintNodes()
        {
            
            Console.Write("Head ->");
            SNode curr = head;
            while (curr.Next != null)
            {
                curr = curr.Next;
                Console.Write(curr.Value);
                Console.Write("->");
            }
            Console.Write("NULL");
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            /* 
             SLL lnklst = new SLL();
             var objct = "abs";
             int cntr = 3;

             bool flag = true;
             while (flag) {
                 Console.WriteLine("Enter \n 1 for add first \n 2 for add at last  \n 3 for delete \n 4 for Traverse ");
                string str = Console.ReadLine();
                int  sw = Convert.ToInt32(str);
                 if (sw > 4 || str == @"^[a-zA-Z]"  )
                 {
                     if (cntr > 0)
                     {
                         throw new Exception("\n Enter number between 1 and 4");
                         cntr--;
                         return;
                     }
                     else flag = false;
                 }
                 else
                 {

                     switch (sw)
                     {
                         case 1: 
                             objct = Console.ReadLine();
                             lnklst.AddStart(objct);
                             break;
                         case 2:
                             objct = Console.ReadLine();
                             lnklst.AddLast(objct); 
                             break;
                         case 3: lnklst.DelStart(); break;
                         case 4: lnklst.PrintNodes(); break;         
                     }




                 }
             }*/
            /* anycls str1 = new anycls();
             anycls str2 = new anycls();
             str1.n="jainil";
             str2.n = "abc";
             string n2 = str1.n;
            n2= n2.Substring(1,n2.Length-1);
             n2 = n2.Replace(,'m');

             Console.WriteLine(n2);

             if (str1.n == str2.n) { Console.WriteLine("entered if"); }*/
            /* for (int j = 0; j < 5; j++)
             {
                 Console.WriteLine("j=" + j);
                 if (j == 1) continue;
                 for (int i = 0; i < 5; i++)
                 {

                     Console.WriteLine(i);
                     if (i == 3) break;

                 }
             }*/
            /*  anycls[] arr = new anycls[3];
              for(int i=0;i<3; i++)
              {
                  arr[i] = new anycls();
                  arr[i].n = "j";
                  arr[i].j = i;
              }
              for(int i = 0; i < 3; i++)
              {
                  anycls k = arr[i];
                 Console.WriteLine(k.j);
              }
              foreach(anycls k in arr) {
                  if (k.j == 1) continue;
                  Console.WriteLine(k.j); }

              */
            var obj1 = new anycls();
            obj1.Name = "kacha badam";
            
            Console.WriteLine(obj1.Name);
            obj1 = new anycls();
            obj1.Name = "jalebi bai";
            Console.WriteLine("Naam "+obj1.Name);


        }
    }
    internal  class  anycls
    {
        private string name;
        public string value;


        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }




        //   public string n;
        // public int j;


    }
    
}
    


