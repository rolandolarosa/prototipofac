
namespace EfideFactoringBE
{
   public class TableBaseBE : GeneralBE
   {
       private string _Table_Id = string.Empty;

       public string Table_Id
       {
           get { return _Table_Id; }
           set { _Table_Id = value; }
       }

       private string _Table_Parent_Id = string.Empty;

       public string Table_Parent_Id
       {
           get { return _Table_Parent_Id; }
           set { _Table_Parent_Id = value; }
       }

       private string _Table_Name = string.Empty;

       public string Table_Name
       {
           get { return _Table_Name; }
           set { _Table_Name = value; }
       }

       private string _Table_Order = string.Empty;

       public string Table_Order
       {
           get { return _Table_Order; }
           set { _Table_Order = value; }
       }

       private string _Table_Value = string.Empty;

       public string Table_Value
       {
           get { return _Table_Value; }
           set { _Table_Value = value; }
       }
   }
}
