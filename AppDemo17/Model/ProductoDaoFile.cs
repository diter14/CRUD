using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppDemo17.Service;
using AppDemo17.Entity;
using System.IO;
using System.Windows.Forms;

namespace AppDemo17.Model
{
  public class ProductoDaoFile : ICrudDao<Producto>
  {
    // variables
    private string archivo = @"..\..\Data\Productos.dat";
    private string temporal = @"..\..\Data\Temporal.dat";
    private FileStream fs;//Abre un archivo para W/R
    private BinaryReader br;//Leer datos de un archivo
    private BinaryWriter bw;//Escribir datos en un archivo
    private string datos;

    //constructor
    public ProductoDaoFile()
    {
      if (!File.Exists(archivo))
      {
        //crear objeto de la clase FileStream
        fs = new FileStream(archivo, FileMode.Create, FileAccess.Write);
        fs.Close();
        MessageBox.Show("Archivo creado con exito !");
      }
    }

    //Métodos de persistencia de datos en archivo .dat

    public void create(Producto o)
    {
      try
      {
        //Abrir archivo para escritura(append)
        fs = new FileStream(archivo, FileMode.Append, FileAccess.Write);
        //Crear objeto para escribir datos en el archivo
        bw = new BinaryWriter(fs);
        //Escribir datos en el archivo
        bw.Write(o.ID);
        bw.Write(o.Nombre);
        bw.Write(o.Categoria);
        bw.Write(o.Precio);
        bw.Write(o.Stock);
        //Cerrar archivo
        bw.Close();
      }
      catch (IOException ex)
      {
        throw ex;
      }
      finally
      {
        fs.Close();
      }
    }

    public void delete(Producto o)
    {
      List<Producto> lproducto = new List<Producto>();
      if (!File.Exists(temporal))
      {
        fs = new FileStream(temporal, FileMode.Create, FileAccess.Write);
        fs.Close();
      }
      try
      {
        if (File.Exists(archivo))
        {
          fs = new FileStream(archivo, FileMode.Open, FileAccess.Read);
          br = new BinaryReader(fs);
          do
          {
            Producto pro = new Producto()
            {
              ID = br.ReadInt32(),
              Nombre = br.ReadString(),
              Categoria = br.ReadString(),
              Precio = br.ReadDecimal(),
              Stock = br.ReadInt32()
            };
            lproducto.Add(pro);
          } while (true);
        }
      }
      catch (IOException ex)
      {
        //throw ex;
      }
      finally
      {
        br.Close();
        fs.Close();
      }

      try
      {
        if (File.Exists(temporal))
        {
          fs = new FileStream(temporal, FileMode.Open, FileAccess.Write);
          bw = new BinaryWriter(fs);
          lproducto.ForEach(delegate(Producto pro)
          {
            if (o.ID != pro.ID)
            {
              bw.Write(pro.ID);
              bw.Write(pro.Nombre);
              bw.Write(pro.Categoria);
              bw.Write(pro.Precio);
              bw.Write(pro.Stock);
            }
          });
        }
      }
      catch (IOException ex)
      {
        //throw ex;
      }
      finally
      {
        //bw.Close();
        bw.Close();
        fs.Close();
      }
      File.Delete(archivo);
      File.Move(temporal, archivo);
    }

    public Producto findForId(int o)
    {
      Producto pro1 = null;
      try
      {
        if (File.Exists(archivo))
        {
          //abrir archivo para lectura
          fs = new FileStream(archivo, FileMode.Open, FileAccess.Read);
          //crear objeto para leer datos del archivo
          br = new BinaryReader(fs);
          do
          {
            Producto pro = new Producto()
            {
              ID = br.ReadInt32(),
              Nombre = br.ReadString(),
              Categoria = br.ReadString(),
              Precio = br.ReadDecimal(),
              Stock = br.ReadInt32()
            };
            if (pro.ID == o)
            {
              pro1 = pro;
            }

          } while (true);
        }
        else
        {
          MessageBox.Show("Archivo no existe");
        }
      }
      catch (IOException ex)
      {
        //throw ex;
      }
      finally
      {
        br.Close();
        fs.Close();
      }
      return pro1;
    }

    public List<Producto> readAll()
    {
      List<Producto> lproducto = new List<Producto>();
      try
      {
        if (File.Exists(archivo))
        {
          //abrir archivo para lectura
          fs = new FileStream(archivo, FileMode.Open, FileAccess.Read);
          //crear objeto para leer datos del archivo
          br = new BinaryReader(fs);
          do
          {
            //Crea objeto pro(Producto) y se asignan valores 
            Producto pro = new Producto()
            {
              ID = br.ReadInt32(),
              Nombre = br.ReadString(),
              Categoria = br.ReadString(),
              Precio = br.ReadDecimal(),
              Stock = br.ReadInt32()
            };
            lproducto.Add(pro);
          } while (true);
        }
        else
        {
          MessageBox.Show("Archivo no existe");
        }
      }
      catch (IOException ex)
      {
        //throw ex;
      }
      finally
      {
        br.Close();
        fs.Close();
      }
      return lproducto;
    }

    public void update(Producto o)
    {
      List<Producto> lproducto = new List<Producto>();
      if (!File.Exists(temporal))
      {
        fs = new FileStream(temporal, FileMode.Create, FileAccess.Write);
        fs.Close();
      }
      try
      {
        if (File.Exists(archivo))
        {
          fs = new FileStream(archivo, FileMode.Open, FileAccess.Read);
          br = new BinaryReader(fs);
          do
          {
            Producto pro = new Producto()
            {
              ID = br.ReadInt32(),
              Nombre = br.ReadString(),
              Categoria = br.ReadString(),
              Precio = br.ReadDecimal(),
              Stock = br.ReadInt32()
            };
            lproducto.Add(pro);
          } while (true);
        }
      }
      catch (IOException ex)
      {
        //throw ex;
      }
      finally
      {
        br.Close();
        fs.Close();
      }

      try
      {
        if (File.Exists(temporal))
        {
          fs = new FileStream(temporal, FileMode.Open, FileAccess.Write);
          bw = new BinaryWriter(fs);
          lproducto.ForEach(delegate(Producto pro)
          {
            if (o.ID == pro.ID)
            {
              bw.Write(o.ID);
              bw.Write(o.Nombre);
              bw.Write(o.Categoria);
              bw.Write(o.Precio);
              bw.Write(o.Stock);
            }
            else
            {
              bw.Write(pro.ID);
              bw.Write(pro.Nombre);
              bw.Write(pro.Categoria);
              bw.Write(pro.Precio);
              bw.Write(pro.Stock);
            }
          });
        }
      }
      catch (IOException ex)
      {
        //throw ex;
      }
      finally
      {
        //bw.Close();
        bw.Close();
        fs.Close();
      }
      File.Delete(archivo);
      File.Move(temporal, archivo);
    }
  }
}
