namespace LinkedLists
{
    /// <summary>
    ///  => LinkedLists
    /// --------Advantages----------
    /// Dynamic Data Structure: Linked list is a dynamic data structure so it can grow and shrink at runtime by allocating and deallocating memeory.
    /// Insertion and Deletion: We just have to update the address present in next pointer of a node.
    /// No Memory Wastage: There is no such problem in linked list as memory is allocated only when required.
    /// -------Disadvantages--------
    /// Memory Usage: In linked list each node contains a pointer and it requires extra memory for itself.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {

            var vid1 = new Youtube() { Title = "ClientsData v0.1" , ID = "ScbHUgWNieo", Duration = new TimeSpan(00, 01, 24) };
            var vid2 = new Youtube() { Title = "ClientsData v0.2", ID = "_9YHo0hvPjE", Duration = new TimeSpan(00, 01, 22) };
            var vid3 = new Youtube() { Title = "ClientsData v0.3", ID = "Ihyw2ryJh2Y", Duration = new TimeSpan(00, 01, 05) };

            var videos = new Youtube[] { vid1, vid2, vid3 };
            LinkedList<Youtube> playlist = new LinkedList<Youtube>(videos);


            //LinkedList<Youtube> playlist = new LinkedList<Youtube>();
            //playlist.AddFirst(vid1);
            //playlist.AddAfter(playlist.First, vid2);// if we want to add more videos U can use Next.Next.Next etc...
            //playlist.AddLast(vid3);
            Console.WriteLine(playlist.First.ValueRef);
            Console.WriteLine(playlist.First.Next);
            Console.WriteLine(playlist.Last);
            Print("My Work", playlist);

            Console.ReadLine();
        }
        static void Print(string title, LinkedList<Youtube> playlist)
        {
            Console.WriteLine($"┌────────────────────────{title}───────────────────────");
            foreach (var video in playlist)
                Console.WriteLine(video);
            Console.WriteLine("└");

            string s = playlist.Count > 1 ? "s" : "";
            Console.WriteLine($"Total: {playlist.Count} Video{s} ");
        }
    }
}