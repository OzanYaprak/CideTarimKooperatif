using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class TeamManager : ITeamService
    {
        private readonly ITeamDAL _teamDAL;

        public TeamManager(ITeamDAL teamDAL)
        {
            _teamDAL = teamDAL;
        }




        public void Add(Team entity)
        {
            _teamDAL.Add(entity);
        }

        public void Delete(Team entity)
        {
            _teamDAL.Delete(entity);
        }

        public List<Team> GetAll()
        {
            return _teamDAL.GetAll();
        }

        public Team GetByID(int id)
        {
            return _teamDAL.GetByID(id);
        }

        public void Update(Team entity)
        {
            _teamDAL.Update(entity);
        }
    }
}
