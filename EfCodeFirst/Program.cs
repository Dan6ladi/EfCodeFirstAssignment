using EfCodeFirst.Model;

namespace EfCodeFirst
{
    public class Program
    {
        static void Main(string[] args)
        {
            ReceievedData();
            Console.WriteLine("Ibrahim");
            Console.ReadLine();
        }
        static void ReceievedData() 
        {
            try
            {
                var mydbcontext = new MyDbContext();
                var salesassociate = new SalesAssociate();
                var subsidiary = new Subsidiary();
                subsidiary.SubsidiaryId = 12345;
                subsidiary.SubsidiaryName = "OxfordHeritageMarvel"; 
                salesassociate.SalesAssociateName = "Ibrahim";
                salesassociate.SalesAssociateId = 12345;
                salesassociate.AccountNo = "01234433";
                salesassociate.Address = "Lagos";
                mydbcontext.SalesAssociate.Add(salesassociate);
                var noOfInsertedRows = mydbcontext.SaveChanges();
                Console.WriteLine($"{noOfInsertedRows} was inserted successfully");


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }

        }
        static void DeleteData() 
        {
            try
            {
                var mydbcontext = new MyDbContext();
                var wantedsalesassociate = mydbcontext.SalesAssociate.Where(x => x.SalesAssociateId == 0);
               
                
                //wantedsalesassociate.SalesAssociateName = "Ibrahim";
                //mydbcontext.SalesAssociate.Remove(wantedsalesassociate);
                //var noOfInsertedRows = mydbcontext.SaveChanges();
                //Console.WriteLine($"{noOfInsertedRows} was inserted successfully");


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }

        }








    }


  
}