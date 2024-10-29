using Candidate_BuisinessObjects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate_DAO
{
    public class CandidateProfileDAO
    {
        private CandidateManagementContext context;
        private static CandidateProfileDAO instance = null;

        public CandidateProfileDAO()
        {
            context = new CandidateManagementContext();
        }

        public static CandidateProfileDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CandidateProfileDAO();
                }
                return instance;
            }
        }

        public CandidateProfile GetCandidateProfileById(string id)
        {
            return context.CandidateProfiles.SingleOrDefault(m => m.CandidateId.Equals(id));
        }

        public List<CandidateProfile> GetCandidateProfiles()
        {
            return context.CandidateProfiles.ToList();
        }

        public bool AddCandidateProfile(CandidateProfile candidateProfile)
        {
            bool isSuccess = false;
            CandidateProfile candidate = this.GetCandidateProfileById(candidateProfile.CandidateId);
            try
            {
                if (candidate == null)
                {
                    context.CandidateProfiles.Add(candidateProfile);
                    context.SaveChanges();
                    isSuccess = true;
                }
            }
            catch (Exception ex)
            {
                LogError(ex); // Ghi log lỗi
                throw; // Ném lại ngoại lệ gốc
            }
            return isSuccess;
        }

        public bool DeleteCandidateProfile(string profileID)
        {
            bool isSuccess = false;
            CandidateProfile candidateProfile = this.GetCandidateProfileById(profileID);
            try
            {
                if (candidateProfile != null) // Kiểm tra xem profile có tồn tại không
                {
                    context.CandidateProfiles.Remove(candidateProfile);
                    context.SaveChanges();
                    isSuccess = true;
                }
                else
                {
                    throw new KeyNotFoundException($"CandidateProfile with ID {profileID} not found.");
                }
            }
            catch (Exception ex)
            {
                LogError(ex); // Ghi log lỗi
                throw; // Ném lại ngoại lệ gốc
            }
            return isSuccess;
        }

        public bool UpdateCandidateProfile(CandidateProfile candidate)
        {
            bool isSuccess = false;

            try
            {
                // Kiểm tra xem thực thể đã được theo dõi chưa
                var existingProfile = context.CandidateProfiles
                                             .FirstOrDefault(p => p.CandidateId == candidate.CandidateId);

                if (existingProfile != null)
                {
                    // Cập nhật các thuộc tính từ candidate vào existingProfile
                    existingProfile.Fullname = candidate.Fullname;
                    existingProfile.Birthday = candidate.Birthday;
                    existingProfile.ProfileShortDescription = candidate.ProfileShortDescription;
                    existingProfile.ProfileUrl = candidate.ProfileUrl;

                    context.SaveChanges();
                    isSuccess = true;
                }
                else
                {
                    throw new KeyNotFoundException($"CandidateProfile with ID {candidate.CandidateId} not found.");
                }
            }
            catch (DbUpdateException dbEx)
            {
                LogError(dbEx); // Ghi log lỗi cụ thể cho việc cập nhật cơ sở dữ liệu
                throw; // Ném lại ngoại lệ gốc
            }
            catch (Exception ex)
            {
                LogError(ex); // Ghi log lỗi khác
                throw; // Ném lại ngoại lệ gốc
            }

            return isSuccess;
        }

        public bool UpdateCandidateProfile(CandidateProfile candidate, string id)
        {
            bool isSuccess = false;

            try
            {
                // Kiểm tra xem thực thể đã được theo dõi chưa
                var existingProfile = context.CandidateProfiles
                                             .FirstOrDefault(p => p.CandidateId == candidate.CandidateId);

                if (existingProfile != null)
                {
                    // Cập nhật các thuộc tính từ candidate vào existingProfile
                    existingProfile.Fullname = candidate.Fullname;
                    existingProfile.Birthday = candidate.Birthday;
                    existingProfile.ProfileShortDescription = candidate.ProfileShortDescription;
                    existingProfile.ProfileUrl = candidate.ProfileUrl;

                    context.SaveChanges();
                    isSuccess = true;
                }
                else
                {
                    throw new KeyNotFoundException($"CandidateProfile with ID {candidate.CandidateId} not found.");
                }
            }
            catch (DbUpdateException dbEx)
            {
                LogError(dbEx); // Ghi log lỗi cụ thể cho việc cập nhật cơ sở dữ liệu
                throw; // Ném lại ngoại lệ gốc
            }
            catch (Exception ex)
            {
                LogError(ex); // Ghi log lỗi khác
                throw; // Ném lại ngoại lệ gốc
            }

            return isSuccess;
        }


        public bool CandidateProfileExists(string id)
        {
            return context.CandidateProfiles.Any(e => e.CandidateId == id);
        }

        // Phương thức ghi log
        private void LogError(Exception ex)
        {
            // Ghi log lỗi vào console (hoặc bạn có thể ghi vào file hoặc cơ sở dữ liệu)
            Console.WriteLine($"Error: {ex.Message}");
            Console.WriteLine($"Stack Trace: {ex.StackTrace}");
        }
    }
}
