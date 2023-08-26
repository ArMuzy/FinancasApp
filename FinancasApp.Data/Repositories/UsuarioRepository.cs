using FinancasApp.Data.Contexts;
using FinancasApp.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancasApp.Data.Repositories
{
    //Classe para desenvolvermos as operações de banco de dados
    //com a entidade Usuario: CRUD - CREATE, READ, UPDATE e DELETE
    public class UsuarioRepository
    {
        //método para inserir um usuário no banco de dados
        public void Create(Usuario usuario)
        {
            //abrindo conexão com o banco de dados
            using (var dataContext = new DataContext())
            {
                dataContext.Add(usuario);
                dataContext.SaveChanges();
            }
        }

        //método para atualizar um usuário no banco de dados
        public void Update(Usuario usuario)
        {
            //abrindo conexão com o banco de dados
            using (var dataContext = new DataContext())
            {
                dataContext.Update(usuario);
                dataContext.SaveChanges();
            }
        }

        //método para excluir um usuário no banco de dados
        public void Delete(Usuario usuario)
        {
            //abrindo conexão com o banco de dados
            using (var dataContext = new DataContext())
            {
                dataContext.Remove(usuario);
                dataContext.SaveChanges();
            }
        }

        //método para consultar todos os usuários
        public List<Usuario> GetAll()
        {
            //abrindo conexão com o banco de dados
            using (var dataContext = new DataContext())
            {
                return dataContext.Usuario
                    .OrderBy(u => u.Nome)
                    .ToList();
            }
        }

        //método para consultar 1 usuário através do ID
        public Usuario? GetById(Guid id)
        {
            //abrindo conexão com o banco de dados
            using (var dataContext = new DataContext())
            {
                return dataContext.Usuario
                    .Where(u => u.Id == id)
                    .FirstOrDefault();
            }
        }

        //método para consultar 1 usuário através do email
        public Usuario? GetByEmail(string email)
        {
            //abrindo conexão com o banco de dados
            using (var dataContext = new DataContext())
            {
                return dataContext.Usuario
                    .Where(u => u.Email == email)
                    .FirstOrDefault();
            }
        }

    }
}


//sempre que add.update ou remove tem que fazer ele (pois é uma modificação)