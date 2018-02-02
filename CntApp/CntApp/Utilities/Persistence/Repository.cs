using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CntApp.Domains.Contacts;
using CntApp.Utilities.Files;
using Lx.Utilities.Contracts.Mapping;
using Lx.Utilities.NetStandard.Pagination;
using Lx.Utilities.NetStandard.PersonName;

namespace CntApp.Utilities.Persistence {
    public class Repository : IRepository {
        private readonly IFileManager _fileManager;
        private readonly IMappingService _mappingService;

        public Repository(IFileManager fileManager, IMappingService mappingService) {
            _fileManager = fileManager;
            _mappingService = mappingService;
        }

        public async Task<ListContactsResult> ListContactsAsync(IPaginationInfo pagination) {
            var result = new ListContactsResult {
                Contacts = new List<Contact> {
                    new Contact {
                        Key = Guid.NewGuid(),
                        PersonName = new PersonName {FamilyName = "abc", GivenName = "123"}
                    },
                    new Contact {
                        Key = Guid.NewGuid(),
                        PersonName = new PersonName {FamilyName = "def", GivenName = "456"}
                    }
                },
                //PaginatedListInfo = _mappingService.Map<PaginatedListInfo>(pagination)
            };

            return await Task.FromResult(result);
        }
    }
}