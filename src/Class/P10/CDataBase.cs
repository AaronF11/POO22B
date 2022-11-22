using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;
using System.Xml.Linq;
using POO22B_FPA.src.DlgsPracticas.P10;

namespace POO22B_FPA.src.Class.P10
{
    //---------------------------------------------------------------------
    //Clase que conecta a base de datos local.
    //FPA. 02/11/2022.
    //---------------------------------------------------------------------
    public class CDataBase
    {
        //---------------------------------------------------------------------
        //Atributos.
        //---------------------------------------------------------------------
        //Atributos de manejo de la base de datos:
        string Path;
        string cs;
        string select;
        string create;

        //Atributos para la interacción con la base de datos:
        SQLiteConnection conn;
        SQLiteCommand cmd;
        SQLiteDataReader reader;

        //Atributos de almacenamiento:
        string id;
        string name;
        string lastname;
        string password;
        string mail;
        string age;

        //Atributos de listas:
        List<string> Names;
        List<string> Lastnames;
        List<string> Building;
        List<string> Models;
        List<String> Tables;

        //Atributo de aleatoriedad:
        Random random;

        //Atributo de identificador:
        string user
        {
            get; set;
        }
        CAlertas Alertas;

        //---------------------------------------------------------------------
        //Constructor.
        //---------------------------------------------------------------------
        public CDataBase()
        {
            Alertas = new CAlertas();
            Path = "database.db";
            cs = @"URI=file:" + Application.StartupPath + "\\database.db";

            Names = new List<string>
            {
                "Hugo",
                "Martín",
                "Lucas",
                "Mateo",
                "Leo",
                "Daniel",
                "Alejandro",
                "Pablo",
                "Manuel",
                "Álvaro",
                "Adrián",
                "David",
                "Mario",
                "Enzo",
                "Diego",
                "Marcos",
                "Izan",
                "Javier",
                "Marco",
                "Álex",
                "Bruno",
                "Oliver",
                "Miguel",
                "Thiago",
                "Antonio"
            };

            Lastnames = new List<string>
            {
                "Hernández",
                "García",
                "Martínez",
                "López",
                "González",
                "Pérez",
                "Rodríguez",
                "Sánchez"
            };

            Building = new List<string>
            {
                "(A) Administración",
                "(B) Derecho",
                "(C) Ing.Civil",
                "(D) Aruitectura",
                "(E) Filosofía",
                "(F) Compulab 1",
                "(G) Compulab 2",
                "(H) Investigación",
                "(I) Posgrado",
                "(J) Enfermería",
            };

            Models = new List<string>
            {
                "Lenovo ThinkCentre M910q",
                "Lenovo IdeaCentre AIO 3i",
                "Lenovo IdeaCentre AIO 3",
                "Apple iMac MK442LL/A",
                "Asus Zen AiO 24",
                "Asus ExpertCenter D500SC",
                "Asus AiO All-in-One Desktop"
            };

            Tables = new List<string>
            {
                "docent",
                "teachers",
                "students",
                "building",
                "computers"
            };
        }

        //---------------------------------------------------------------------
        //Crea la base de datos si es que no existe.
        //---------------------------------------------------------------------
        public void Create_db()
        {
            if (!System.IO.File.Exists(Path))
            {
                SQLiteConnection.CreateFile(Path);
                using (var SQLite = new SQLiteConnection(@"Data Source=" + Path))
                {
                    SQLite.Open();
                    //Tabla de usuarios.
                    create = "CREATE TABLE users(name varchar(30), password varchar(30), mail varchar(50))";
                    cmd = new SQLiteCommand(create, SQLite);
                    cmd.ExecuteNonQuery();

                    conn = new SQLiteConnection(cs);
                    conn.Open();
                    cmd = new SQLiteCommand(conn);
                    cmd.CommandText = "INSERT INTO users(name, password, mail) VALUES(@name, @password, @mail)";

                    name = "AARON FLORES PASOS";
                    password = "Asdfghjk.1";
                    mail = "aaron.flores7908@alumnos.udg.mx";

                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@mail", mail);
                    cmd.ExecuteNonQuery();

                    //Tabla de docentes.
                    create = "CREATE TABLE docent(id varchar(10), name varchar(30), lastname varchar(30), age varchar(30))";
                    cmd = new SQLiteCommand(create, SQLite);
                    cmd.ExecuteNonQuery();

                    random = new Random();
                    for (int i = 0; i <= 100; i++)
                    {
                        conn = new SQLiteConnection(cs);
                        conn.Open();
                        cmd = new SQLiteCommand(conn);
                        cmd.CommandText = "INSERT INTO docent(id, name, lastname, age) VALUES(@id, @name, @lastname, @age)";

                        if (i <= 9) id = "1000" + i.ToString();
                        else id = "100" + i.ToString();
                        name = Names[random.Next(0, Names.Count)];
                        lastname = Lastnames[random.Next(0, Lastnames.Count)];
                        age = random.Next(25, 60).ToString();

                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@lastname", lastname);
                        cmd.Parameters.AddWithValue("@age", age);
                        cmd.ExecuteNonQuery();
                    }

                    //Tabla de maestros.
                    create = "CREATE TABLE teachers(id varchar(10), name varchar(30), lastname varchar(30), age varchar(30), mail varchar(50))";
                    cmd = new SQLiteCommand(create, SQLite);
                    cmd.ExecuteNonQuery();

                    random = new Random();
                    for (int i = 0; i <= 100; i++)
                    {
                        conn = new SQLiteConnection(cs);
                        conn.Open();
                        cmd = new SQLiteCommand(conn);
                        cmd.CommandText = "INSERT INTO teachers(id, name, lastname, age, mail) VALUES(@id, @name, @lastname, @age, @mail)";

                        if (i <= 9) id = "2000" + i.ToString();
                        else id = "200" + i.ToString();
                        name = Names[random.Next(0, Names.Count)];
                        lastname = Lastnames[random.Next(0, Lastnames.Count)];
                        age = random.Next(25, 60).ToString();
                        mail = (name + "." + lastname + random.Next(7000, 8000).ToString() + "@maestros.udg.mx").ToLower();

                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@lastname", lastname);
                        cmd.Parameters.AddWithValue("@age", age);
                        cmd.Parameters.AddWithValue("@mail", mail);

                        cmd.ExecuteNonQuery();
                    }

                    //Tabla de alumnos.
                    create = "CREATE TABLE students(id varchar(10), name varchar(30), lastname varchar(30), age varchar(30), mail varchar(50))";
                    cmd = new SQLiteCommand(create, SQLite);
                    cmd.ExecuteNonQuery();

                    random = new Random();
                    for (int i = 0; i <= 100; i++)
                    {
                        conn = new SQLiteConnection(cs);
                        conn.Open();
                        cmd = new SQLiteCommand(conn);
                        cmd.CommandText = "INSERT INTO students(id, name, lastname, age, mail) VALUES(@id, @name, @lastname, @age, @mail)";

                        if (i <= 9) id = "22197900" + i.ToString();
                        else id = "2219790" + i.ToString();
                        name = Names[random.Next(0, Names.Count)];
                        lastname = Lastnames[random.Next(0, Lastnames.Count)];
                        age = random.Next(18, 27).ToString();
                        mail = (name + "." + lastname + random.Next(7000, 8000).ToString() + "@alumnos.udg.mx").ToLower();

                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@lastname", lastname);
                        cmd.Parameters.AddWithValue("@age", age);
                        cmd.Parameters.AddWithValue("@mail", mail);

                        cmd.ExecuteNonQuery();
                    }

                    //Tabla de edificios.
                    create = "CREATE TABLE building(id varchar(5), name varchar(30))";
                    cmd = new SQLiteCommand(create, SQLite);
                    cmd.ExecuteNonQuery();

                    random = new Random();
                    for (int i = 0; i < Building.Count; i++)
                    {
                        conn = new SQLiteConnection(cs);
                        conn.Open();
                        cmd = new SQLiteCommand(conn);
                        cmd.CommandText = "INSERT INTO building(id, name) VALUES(@id, @name)";

                        id = i.ToString();
                        name = "Edificio - " + Building[i];

                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@name", name);

                        cmd.ExecuteNonQuery();
                    }

                    //Tabla de equipos TI.
                    create = "CREATE TABLE computers(id varchar(5), model varchar(30))";
                    cmd = new SQLiteCommand(create, SQLite);
                    cmd.ExecuteNonQuery();

                    random = new Random();
                    for (int i = 0; i <= 100; i++)
                    {
                        conn = new SQLiteConnection(cs);
                        conn.Open();
                        cmd = new SQLiteCommand(conn);
                        cmd.CommandText = "INSERT INTO computers(id, model) VALUES(@id, @model)";

                        id = "79C64A25-B3CD-4171-BBC5-FC09E0A856" + random.Next(0, 100);
                        name = Models[random.Next(0, Models.Count)];

                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@model", name);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }

        //---------------------------------------------------------------------
        //Verifica los datos dentro de la base de datos para ingresar.
        //---------------------------------------------------------------------
        public void Verification(TextBox Name, TextBox Password)
        {
            conn = new SQLiteConnection(cs);
            try
            {
                conn.Open();
                select = "SELECT * FROM users WHERE name='" + Name.Text + "' AND password='" + Password.Text + "'";
                cmd = new SQLiteCommand(select, conn);
                cmd.ExecuteNonQuery();
                reader = cmd.ExecuteReader();
                int count = 0;

                while (reader.Read())
                {
                    count++;
                }

                if (count == 1)
                {
                    Properties.Settings.Default.Name = Name.Text;
                    DlgMain dlgMain = new DlgMain();
                    dlgMain.Show();
                }

                if (count < 1)
                {
                    NotifyIcon Notify = new NotifyIcon();
                    Notify.Visible = true;
                    Notify.Icon = Properties.Resources.IcoPersona;
                    Notify.BalloonTipTitle = "Credenciales invalidas";
                    Notify.BalloonTipText = "Ingrese sus credenciales correctamente";
                    Notify.ShowBalloonTip(1000);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex);
            }
        }

        //---------------------------------------------------------------------
        //Registrar nuevo usuario en la base de datos.
        //---------------------------------------------------------------------
        public void Register(TextBox Name, TextBox Mail, TextBox Password)
        {
            conn = new SQLiteConnection(cs);
            try
            {
                conn.Open();
                cmd = new SQLiteCommand(conn);
                cmd.CommandText = "INSERT INTO users(name, password, mail) VALUES(@name, @password, @mail)";

                string name = Name.Text;
                string password = Password.Text;
                string mail = Mail.Text;

                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@mail", mail);
                cmd.ExecuteNonQuery();

                DlgLogin dlgLogin = new DlgLogin();
                dlgLogin.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex);
            }
        }

        //---------------------------------------------------------------------
        //Guarda el nombre y correo para utilizarlo en el main.
        //---------------------------------------------------------------------
        public void Send(Label LblName, Label LblMail)
        {
            conn = new SQLiteConnection(cs);
            try
            {
                conn.Open();
                select = "SELECT mail FROM users WHERE name='" + Properties.Settings.Default.Name + "'";
                cmd = new SQLiteCommand(select, conn);
                cmd.ExecuteNonQuery();
                using (var reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    string simpleValue = reader.GetString(0);
                    LblName.Text = Properties.Settings.Default.Name;
                    LblMail.Text = simpleValue;
                    user = Properties.Settings.Default.Name;
                    Alertas.SMS(0, user);
                }
            }
            catch
            {
                user = "usuario desconocido";
                MessageBox.Show("Error : No se reconoce el usuario.");
            }
        }

        //---------------------------------------------------------------------
        //Comparte los datos de la tabla de la base de datos
        //al DataGridView.
        //---------------------------------------------------------------------
        public void Show_Table(int Table, DataGridView Dgv)
        {
            var conn = new SQLiteConnection(cs);
            conn.Open();

            select = $"SELECT * FROM {Tables[Table]}";
            cmd = new SQLiteCommand(select, conn);
            reader = cmd.ExecuteReader();
            switch (Table)
            {
                case 0:
                    while (reader.Read())
                    {
                        Dgv.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3));
                    }
                    break;
                case 1:
                    while (reader.Read())
                    {
                        Dgv.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4));
                    }
                    break;
                case 2:
                    while (reader.Read())
                    {
                        Dgv.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4));
                    }
                    break;
                case 3:
                    while (reader.Read())
                    {
                        Dgv.Rows.Add(reader.GetString(0), reader.GetString(1));
                    }
                    break;
                case 4:
                    while (reader.Read())
                    {
                        Dgv.Rows.Add(reader.GetString(0), reader.GetString(1));
                    }
                    break;
            }
        }

        //---------------------------------------------------------------------
        //Inserta datos dentro de la base de datos.
        //---------------------------------------------------------------------
        public void Insert_Into(int Table, DataGridView Dgv, TextBox id, TextBox name, TextBox lastname, TextBox age, TextBox mail, TextBox model)
        {
            conn = new SQLiteConnection(cs);
            conn.Open();
            cmd = new SQLiteCommand(conn);

            switch (Table)
            {
                case 0:
                    try
                    {
                        cmd.CommandText = $"INSERT INTO {Tables[Table]}(id, name, lastname, age) VALUES(@id, @name, @lastname, @age)";

                        cmd.Parameters.AddWithValue("@id", id.Text);
                        cmd.Parameters.AddWithValue("@name", name.Text);
                        cmd.Parameters.AddWithValue("@lastname", lastname.Text);
                        cmd.Parameters.AddWithValue("@age", age.Text);

                        string[] row = new string[] {id.Text, name.Text, lastname.Text, age.Text };
                        Dgv.Rows.Add(row);

                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                    break;
                case 1:
                    try
                    {
                        cmd.CommandText = $"INSERT INTO {Tables[Table]}(id, name, lastname, age, mail) VALUES(@id, @name, @lastname, @age, @mail)";

                        cmd.Parameters.AddWithValue("@id", id.Text);
                        cmd.Parameters.AddWithValue("@name", name.Text);
                        cmd.Parameters.AddWithValue("@lastname", lastname.Text);
                        cmd.Parameters.AddWithValue("@age", age.Text);
                        cmd.Parameters.AddWithValue("@mail", mail.Text);

                        string[] row = new string[] { id.Text, name.Text, lastname.Text, age.Text, mail.Text };
                        Dgv.Rows.Add(row);

                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                    break;
                case 2:
                    try
                    {
                        cmd.CommandText = $"INSERT INTO {Tables[Table]}(id, name, lastname, age, mail) VALUES(@id, @name, @lastname, @age, @mail)";

                        cmd.Parameters.AddWithValue("@id", id.Text);
                        cmd.Parameters.AddWithValue("@name", name.Text);
                        cmd.Parameters.AddWithValue("@lastname", lastname.Text);
                        cmd.Parameters.AddWithValue("@age", age.Text);
                        cmd.Parameters.AddWithValue("@mail", mail.Text);

                        string[] row = new string[] { id.Text, name.Text, lastname.Text, age.Text, mail.Text };
                        Dgv.Rows.Add(row);

                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                    break;
                case 3:
                    try
                    {
                        cmd.CommandText = $"INSERT INTO {Tables[Table]}(id, name) VALUES(@id, @name)";

                        cmd.Parameters.AddWithValue("@id", id.Text);
                        cmd.Parameters.AddWithValue("@name", name.Text);

                        string[] row = new string[] { id.Text, name.Text };
                        Dgv.Rows.Add(row);

                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                    break;
                case 4:
                    try
                    {
                        cmd.CommandText = $"INSERT INTO {Tables[Table]}(id, model) VALUES(@id, @model)";

                        cmd.Parameters.AddWithValue("@id", id.Text);
                        cmd.Parameters.AddWithValue("@model", model.Text);

                        string[] row = new string[] { id.Text, model.Text };
                        Dgv.Rows.Add(row);

                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                    break;
            }
            Alertas.SMS(Tables[Table], 2);
        }

        //---------------------------------------------------------------------
        //Actualiza datos dentro de la base de datos.
        //---------------------------------------------------------------------
        public void Update(int Table, DataGridView Dgv, TextBox id, TextBox name, TextBox lastname, TextBox age, TextBox mail, TextBox model)
        {
            conn = new SQLiteConnection(cs);
            conn.Open();
            cmd = new SQLiteCommand(conn);

            switch (Table)
            {
                case 0:
                    try
                    {
                        cmd.CommandText = $"UPDATE {Tables[Table]} SET name=@name, lastname=@lastname, age=@age WHERE id=@id";
                        cmd.Prepare();

                        cmd.Parameters.AddWithValue("@id", id.Text);
                        cmd.Parameters.AddWithValue("@name", name.Text);
                        cmd.Parameters.AddWithValue("@lastname", lastname.Text);
                        cmd.Parameters.AddWithValue("@age", age.Text);

                        cmd.ExecuteNonQuery();
                        Dgv.Rows.Clear();
                        Show_Table(Table, Dgv);
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                    break;
                case 1:
                    try
                    {
                        cmd.CommandText = $"UPDATE {Tables[Table]} SET name=@name, lastname=@lastname, age=@age, mail=@mail WHERE id=@id";
                        cmd.Prepare();

                        cmd.Parameters.AddWithValue("@id", id.Text);
                        cmd.Parameters.AddWithValue("@name", name.Text);
                        cmd.Parameters.AddWithValue("@lastname", lastname.Text);
                        cmd.Parameters.AddWithValue("@age", age.Text);
                        cmd.Parameters.AddWithValue("@mail", mail.Text);

                        cmd.ExecuteNonQuery();
                        Dgv.Rows.Clear();
                        Show_Table(Table, Dgv);
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                    break;
                case 2:
                    try
                    {
                        cmd.CommandText = $"UPDATE {Tables[Table]} SET name=@name, lastname=@lastname, age=@age, mail=@mail WHERE id=@id";
                        cmd.Prepare();

                        cmd.Parameters.AddWithValue("@id", id.Text);
                        cmd.Parameters.AddWithValue("@name", name.Text);
                        cmd.Parameters.AddWithValue("@lastname", lastname.Text);
                        cmd.Parameters.AddWithValue("@age", age.Text);
                        cmd.Parameters.AddWithValue("@mail", mail.Text);

                        cmd.ExecuteNonQuery();
                        Dgv.Rows.Clear();
                        Show_Table(Table, Dgv);
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                    break;
                case 3:
                    try
                    {
                        cmd.CommandText = $"UPDATE {Tables[Table]} SET name=@name WHERE id=@id";
                        cmd.Prepare();

                        cmd.Parameters.AddWithValue("@id", id.Text);
                        cmd.Parameters.AddWithValue("@name", name.Text);

                        cmd.ExecuteNonQuery();
                        Dgv.Rows.Clear();
                        Show_Table(Table, Dgv);
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                    break;
                case 4:
                    try
                    {
                        cmd.CommandText = $"UPDATE {Tables[Table]} SET model=@model WHERE id=@id";
                        cmd.Prepare();

                        cmd.Parameters.AddWithValue("@id", id.Text);
                        cmd.Parameters.AddWithValue("@model", model.Text);

                        cmd.ExecuteNonQuery();
                        Dgv.Rows.Clear();
                        Show_Table(Table, Dgv);
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                    break;
            }
            Alertas.SMS(Tables[Table], 3);
        }

        //---------------------------------------------------------------------
        //Elimina datos dentro de la base de datos.
        //---------------------------------------------------------------------
        public void Delete(int Table, DataGridView Dgv, TextBox id, TextBox name, TextBox lastname, TextBox age, TextBox mail, TextBox model)
        {
            conn = new SQLiteConnection(cs);
            conn.Open();
            cmd = new SQLiteCommand(conn);

            switch (Table)
            {
                case 0:
                    try
                    {
                        cmd.CommandText = $"DELETE FROM {Tables[Table]} WHERE id=@id";
                        cmd.Prepare();

                        cmd.Parameters.AddWithValue("@id", id.Text);

                        cmd.ExecuteNonQuery();
                        Dgv.Rows.Clear();
                        Show_Table(Table, Dgv);
                        id.Clear();
                        name.Clear();
                        lastname.Clear();
                        age.Clear();
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                    break;
                case 1:
                    try
                    {
                        cmd.CommandText = $"DELETE FROM {Tables[Table]} WHERE id=@id";
                        cmd.Prepare();

                        cmd.Parameters.AddWithValue("@id", id.Text);

                        cmd.ExecuteNonQuery();
                        Dgv.Rows.Clear();
                        Show_Table(Table, Dgv);
                        id.Clear();
                        name.Clear();
                        lastname.Clear();
                        age.Clear();
                        mail.Clear();
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                    break;
                case 2:
                    try
                    {
                        cmd.CommandText = $"DELETE FROM {Tables[Table]} WHERE id=@id";
                        cmd.Prepare();

                        cmd.Parameters.AddWithValue("@id", id.Text);

                        cmd.ExecuteNonQuery();
                        Dgv.Rows.Clear();
                        Show_Table(Table, Dgv);
                        id.Clear();
                        name.Clear();
                        lastname.Clear();
                        age.Clear();
                        mail.Clear();
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                    break;
                case 3:
                    try
                    {
                        cmd.CommandText = $"DELETE FROM {Tables[Table]} WHERE id=@id";
                        cmd.Prepare();

                        cmd.Parameters.AddWithValue("@id", id.Text);

                        cmd.ExecuteNonQuery();
                        Dgv.Rows.Clear();
                        Show_Table(Table, Dgv);
                        id.Clear();
                        name.Clear();
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                    break;
                case 4:
                    try
                    {
                        cmd.CommandText = $"DELETE FROM {Tables[Table]} WHERE id=@id";
                        cmd.Prepare();

                        cmd.Parameters.AddWithValue("@id", id.Text);

                        cmd.ExecuteNonQuery();
                        Dgv.Rows.Clear();
                        Show_Table(Table, Dgv);
                        id.Clear();
                        model.Clear();
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                    break;
            }
            Alertas.SMS(Tables[Table], 4);
        }
    }
}
