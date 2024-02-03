using ConsoleApp2.Db;
using ConsoleApp2.Utils;

string com = "COM10";

UtilCom uc = new UtilCom(com);
UtilDb db = new UtilDb();

while (true)
{
    Dato dato = uc.leer();

    if (dato != null)
    {
        db.add(dato);
    }
}