using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.GenericRepository.IntRep
{
    public interface IRepository<T> where T : BaseEntity
    {
        //list commands

        List<T> GetAll();
        List<T> GetPassives();
        List<T> GetActives();
        List<T> GetModifieds();

        // Modification Commands

        void Add(T item);
        void AddRange(List<T> list);
        void Remove(T item);
        void RemoveRange(List<T> list);
        void Update(T item);
        void UpdateTange(List<T> list);
        void Destroy(T item);
        void DestroyRange(List<T> list);

        //Linq Expressions
        List<T> Where(Expression<Func<T, bool>> exp);
        
        bool Any(Expression<Func<T, bool>> exp);

        T FirstOrDefault(Expression<Func<T, bool>> exp);

        IQueryable<X> Select<X>(Expression<Func<T, X>> exp) where X:class;

        //Find Command
        T Find(int id);

        //get last datas
        List<T> GetLastDatas(int number);

        //get first datas
        List<T> GetFirstDatas(int number);

        //get counted datas
        List<T> GetCountedDatas(int number);
    }
}
