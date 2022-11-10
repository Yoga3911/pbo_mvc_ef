namespace Controller
{

    public class User
    {
        PboContext db;
        public User()
        {
            db = new PboContext();
        }

        public void call()
        {
            Model.User userM = new Model.User { id = 1, nama = "Budi", alamat = "Jl Mawar" };

            View.User.cetakIdentitas(userM);
        }

        public void getAll()
        {
            var users = db.Users;

            if (users != null)
            {
                foreach (var user in users)
                {
                    Console.WriteLine($"{user.id}. {user.nama} - {user.alamat}");
                }
            }
        }

        public void getById(int userId)
        {
            var user = db.Users?.Find(userId);
            Console.WriteLine($"{user?.id}. {user?.nama} - {user?.alamat}");
        }

        public void insert(Model.User model)
        {
            db.Users?.Add(model);
            db.SaveChanges();
        }

        public void update(Model.User model)
        {
            db.Users?.Update(model);
            db.SaveChanges();
        }

        public void delete(int userId)
        {
            db.Users?.Remove(new Model.User { id = userId });
            db.SaveChanges();
        }
    }

}