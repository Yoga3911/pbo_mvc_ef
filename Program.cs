
class Program
{
    static void Main()
    {
        Controller.User userC = new Controller.User();

        // userC.insert(new Model.User { nama = "Ahmad", alamat = "Jl Mawar" });
        // userC.delete(userId: 4);
        userC.update(new Model.User{id = 5, nama = "Pras", alamat = "Jl Melati"});
        userC.getAll();
        // userC.getById(3);
    }
}



