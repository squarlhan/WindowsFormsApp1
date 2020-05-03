using OPCAutomation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KEPTest
{
    class Program
    {
        OPCServer MyOpcServer;  //opcserver
        OPCGroups groups;
        OPCGroup MyOpcGroup;
        OPCItem MyOpcItem1;
        OPCItem MyOpcItem2;

        void runme()
        {
            

            int[] ServerHandle = new int[2]; //

            const int READASYNC_ID = 1;
            const int WRITEASYNC_ID = 2;

            MyOpcServer = new OPCServer();
            MyOpcServer.Connect("Kepware.KEPServerEX.V6", "127.0.0.1");


            groups = MyOpcServer.OPCGroups;
            MyOpcGroup = MyOpcServer.OPCGroups.Add("MyGroup1");
            MyOpcGroup.IsActive = true;
            MyOpcGroup.IsSubscribed = true;
            MyOpcGroup.DeadBand = 0;
            MyOpcGroup.UpdateRate = 1000;

            MyOpcItem1 = MyOpcGroup.OPCItems.AddItem("通道 1.设备 1.标记 1", 0);
            MyOpcItem2 = MyOpcGroup.OPCItems.AddItem("通道 1.设备 1.TAG1", 1);

            ServerHandle[0] = MyOpcItem1.ServerHandle;
            ServerHandle[1] = MyOpcItem2.ServerHandle;

            MyOpcGroup.AsyncWriteComplete += new DIOPCGroupEvent_AsyncWriteCompleteEventHandler(MyOpcGroup_AsyncWriteComplete);
            MyOpcGroup.AsyncReadComplete += new DIOPCGroupEvent_AsyncReadCompleteEventHandler(MyOpcGroup_AsyncReadComplete);
            MyOpcGroup.AsyncCancelComplete += new DIOPCGroupEvent_AsyncCancelCompleteEventHandler(MyOpcGroup_AsyncCancelComplete);
            MyOpcGroup.DataChange += new DIOPCGroupEvent_DataChangeEventHandler(MyOpcGroup_DataChange);

            


        }

        void MyOpcGroup_AsyncCancelComplete(int CancelID)
        {
            throw new NotImplementedException();
        }

        void MyOpcGroup_AsyncReadComplete(int TransactionID, int NumItems, ref Array ClientHandles, ref Array ItemValues, ref Array Qualities, ref Array TimeStamps, ref Array Errors)
        {
            throw new NotImplementedException();
        }

        void MyOpcGroup_AsyncWriteComplete(int TransactionID, int NumItems, ref Array ClientHandles, ref Array Errors)
        {
            throw new NotImplementedException();
        }

        void MyOpcGroup_DataChange(int TransactionID, int NumItems, ref Array ClientHandles, ref Array ItemValues, ref Array Qualities, ref Array TimeStamps)
        {
            try
            {

                Console.WriteLine(string.Format("{0}", MyOpcItem1.Value));
                Console.WriteLine(string.Format("{0}", MyOpcItem1.Quality));
                Console.WriteLine(string.Format("{0}", MyOpcItem1.TimeStamp));


                Console.WriteLine(string.Format("{0}", MyOpcItem2.Value));
                Console.WriteLine(string.Format("{0}", MyOpcItem2.Quality));
                Console.WriteLine(string.Format("{0}", MyOpcItem2.TimeStamp));

            }
            catch (System.Exception error)
            {
                Console.WriteLine("Result--同步读:"+error.Message);
            }
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            while (true)
            {
                p.runme();
            }
        }

    }
}
