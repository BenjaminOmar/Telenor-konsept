using Domain.DTOs.Status;

namespace Domain.DTOs.Customer;

public class CustomerOptionsResponseDto
{
    public List<StatusListResponseDto>? Status { get; set; }
}