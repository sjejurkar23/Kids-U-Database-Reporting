﻿using Kids_U_Database_Reporting.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kids_U_Database_Reporting.Services
{
    public interface IOrganizationsService
    {
        Task<Organization[]> GetOrganizationsAsync();

        Task<Organization> EditOrganizationAsync(int Id);

        Task<bool> DeleteOrganizationAsync(int Id);

        Task<bool> AddOrganizationAsync(Organization newOrganization);

        Task<bool> ApplyEditOrganizationAsync(Organization editedOrganization);
    }
}
