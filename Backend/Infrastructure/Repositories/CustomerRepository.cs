using System.Text.Json;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Domain.DTOs.Customer;
using Domain.Entities;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services.User;
using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Infrastructure.Repositories;

public class CustomerRepository(DataContext context, IMapper mapper, ICurrentUserService currentUserService, IConfiguration contConfiguration) : BaseRepository<Customer>(context), ICustomerRepository
{
    private readonly DataContext _context = context;
    private readonly IMapper _mapper = mapper;
    private readonly ICurrentUserService _currentUserService = currentUserService;
    private readonly IConfiguration _configuration = contConfiguration;
    private static readonly HttpClient HttpClient = new();

    public async Task<List<CustomerListResponseDto>> GetCustomerList()
    {
        IQueryable<Customer> customerQuery = _context.Customers;

        return await customerQuery
            .Where(c => c.BusinessId == _currentUserService.BusinessId)
            .OrderByDescending(c => c.CreatedOn)
            .ProjectTo<CustomerListResponseDto>(_mapper.ConfigurationProvider)
            .ToListAsync();
    }

    public async Task<bool> CheckCustomerNameExists(string customerName)
    {
        IQueryable<Customer> customerQuery = _context.Customers;

        return await customerQuery
            .Where(c => c.BusinessId == _currentUserService.BusinessId)
            .AnyAsync(c => c.Name == customerName);

    }
    
    public async Task<bool> CheckOrgNrExists(int organizationNr)
    {
        IQueryable<Customer> customerQuery = _context.Customers;

        return await customerQuery
            .Where(c => c.BusinessId == _currentUserService.BusinessId)
            .AnyAsync(c => c.OrganizationNr == organizationNr);
    }

    public async Task<List<BrregResponseDto>> GetBrregCompanyInformation(string? name, string? organizationNumber)
    {
        var baseUrl = _configuration.GetValue<string>("brreg:BasePath")!;
        var queryParameters = new List<string>();

        if (!string.IsNullOrEmpty(name))
        {
            queryParameters.Add($"navn={Uri.EscapeDataString(name)}");
        }
        if (!string.IsNullOrEmpty(organizationNumber))
        {
            queryParameters.Add($"organisasjonsnummer={Uri.EscapeDataString(organizationNumber)}");
        }
    
        var url = $"{baseUrl}?{string.Join("&", queryParameters)}";
        var request = new HttpRequestMessage(HttpMethod.Get, url);
        request.Headers.Add("Accept", _configuration.GetValue<string>("brreg:RequestHeaders")!);

        var response = await HttpClient.SendAsync(request);
        response.EnsureSuccessStatusCode();
        var content = await response.Content.ReadAsStringAsync();

        var apiResponse = JsonSerializer.Deserialize<BrregSerializerHelperDto.BrregApiResponse>(content, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

        var result = new List<BrregResponseDto>();
        if (apiResponse != null && apiResponse._embedded != null && apiResponse._embedded.enheter != null)
        {
            result = apiResponse._embedded.enheter.Select(e => new BrregResponseDto
            {
                Name = e.navn,
                OrganizationNumber = e.organisasjonsnummer,
                Forretningsadresse = e.forretningsadresse != null ? new BrregSerializerHelperDto.Forretningsadresse
                {
                    Land = e.forretningsadresse.Land,
                    Landkode = e.forretningsadresse.Landkode,
                    Postnummer = e.forretningsadresse.Postnummer,
                    Poststed = e.forretningsadresse.Poststed,
                    Adresse = e.forretningsadresse.Adresse,
                    Kommune = e.forretningsadresse.Kommune,
                    Kommunenummer = e.forretningsadresse.Kommunenummer
                } : null
            }).ToList();
        }

        return result;
    }

}