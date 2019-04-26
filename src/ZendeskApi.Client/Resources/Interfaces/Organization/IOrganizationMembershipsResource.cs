using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using ZendeskApi.Client.Models;
using ZendeskApi.Client.Responses;

namespace ZendeskApi.Client.Resources
{
    public interface IOrganizationMembershipsResource
    {
        Task<IPagination<OrganizationMembership>> GetAllAsync(
            PagerParameters pager = null,
            CancellationToken cancellationToken = default(CancellationToken));

        Task<IPagination<OrganizationMembership>> GetAllForOrganizationAsync(
            long organizationId, 
            PagerParameters pager = null,
            CancellationToken cancellationToken = default(CancellationToken));

        Task<IPagination<OrganizationMembership>> GetAllForUserAsync(
            long userId, 
            PagerParameters pager = null,
            CancellationToken cancellationToken = default(CancellationToken));

        Task<OrganizationMembership> GetAsync(
            long id,
            CancellationToken cancellationToken = default(CancellationToken));

        Task<OrganizationMembership> GetForUserAndOrganizationAsync(
            long userId, 
            long organizationId,
            CancellationToken cancellationToken = default(CancellationToken));

        Task<OrganizationMembership> CreateAsync(
            OrganizationMembership organizationMembership,
            CancellationToken cancellationToken = default(CancellationToken));

        Task<OrganizationMembership> PostForUserAsync(
            OrganizationMembership organizationMembership, 
            long userId,
            CancellationToken cancellationToken = default(CancellationToken));

        Task<JobStatusResponse> CreateAsync(
            IEnumerable<OrganizationMembership> organizationMemberships,
            CancellationToken cancellationToken = default(CancellationToken));

        Task<IPagination<OrganizationMembership>> MakeDefault(
            long userId, 
            long organizationMembershipId,
            CancellationToken cancellationToken = default(CancellationToken));

        Task DeleteAsync(
            long organizationMembershipId,
            CancellationToken cancellationToken = default(CancellationToken));

        Task DeleteAsync(
            long userId, 
            long organizationMembershipId,
            CancellationToken cancellationToken = default(CancellationToken));

        Task DeleteAsync(
            IEnumerable<long> organizationMembershipIds,
            CancellationToken cancellationToken = default(CancellationToken));
    }
}