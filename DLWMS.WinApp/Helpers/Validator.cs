namespace DLWMS.WinApp.Helpers
{
    public class Validator
    {
        public static bool ProvjeriUnos(TextBox textBox, ErrorProvider err, string poruka)
        {
            if (!textBox.Text.IsSet())
            {
                err.SetError(textBox, poruka);
                return false;
            }
            err.Clear();
            return true;
        }
    }
}
