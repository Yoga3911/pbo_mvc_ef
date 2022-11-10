namespace View
{

    class User
    {
        static public void cetakIdentitas(Model.User model)
        {
            Console.WriteLine($"{model.id}. {model.nama} - {model.alamat}");
        }
    }

}