using AutoMapper;
using PhotoForum.BLL.Services.Interfaces;
using PhotoForum.Common.DTO;
using PhotoForum.Common.Exceptions;
using PhotoForum.DAL.Entities;
using PhotoForum.DAL.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoForum.BLL.Services
{
    public class DisscussionService : IDisscussionService
    {
        private readonly IDisscussionRepository _repo;
        private readonly IMapper _mapper;
        public DisscussionService(IDisscussionRepository repo,IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task<bool> CreateAsync(CreateDisscussionDTO publicationDTO)
        {
            var data = _mapper.Map<Disscusion>(publicationDTO);
            return await _repo.AddAsync(data);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var data = await _repo.GetAsync(id);
            if (data != null)
            {
                return await _repo.DeleteAsync(data);
            }
            throw new NotFoundException(id);
        }

        public async Task<List<DisscussionDTO>> GetAllAsync()
        {
            var data=await _repo.GetAllAsync();
            return _mapper.Map<List<DisscussionDTO>>(data);
        }

        public async Task<DisscussionDTO> GetByIdAsync(int id)
        {
            var data = await _repo.GetAsync(id);
            return _mapper.Map<DisscussionDTO>(data);
        }

        public async Task<bool> UpdateAsync(CreateDisscussionDTO publicationDTO, int Id)
        {
            var data = await _repo.GetAsync(Id)
                    ?? throw new NotFoundException(Id);

            _mapper.Map(publicationDTO, data);

            return await _repo.UpdateAsync(data);
        }
    }
}
