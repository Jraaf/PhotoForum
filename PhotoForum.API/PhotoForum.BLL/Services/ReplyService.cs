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
    public class ReplyService:IReplyService
    {
        private readonly IReplyRepository _repo;
        private readonly IMapper _mapper;
        public ReplyService(IReplyRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task<bool> CreateAsync(CreateReplyDTO replyDTO)
        {
            var data = _mapper.Map<Reply>(replyDTO);
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

        public async Task<List<ReplyDTO>> GetAllAsync()
        {
            var data = await _repo.GetAllAsync();
            return _mapper.Map<List<ReplyDTO>>(data);
        }

        public async Task<ReplyDTO> GetByIdAsync(int id)
        {
            var data = await _repo.GetAsync(id);
            return _mapper.Map<ReplyDTO>(data);
        }

        public async Task<bool> UpdateAsync(CreateReplyDTO replyDTO, int Id)
        {
            var data = await _repo.GetAsync(Id)
                    ?? throw new NotFoundException(Id);

            _mapper.Map(replyDTO, data);

            return await _repo.UpdateAsync(data);
        }
    }
}
