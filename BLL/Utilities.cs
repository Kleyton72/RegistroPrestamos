
namespace RegistroPrestamos.BLL
{
    public class Utilities{
        public static int ToInt(string value)
        {
            int return_ = 0;

            int.TryParse(value, out return_);

            return return_;
        }

        public static decimal ToDecimal(string value)
        {
            decimal return_ = 0;

            decimal.TryParse(value, out return_);

            return return_;
        }
    }
}