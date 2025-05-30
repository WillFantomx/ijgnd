// Copyright (c) MASA Stack All rights reserved.
// Licensed under the MIT License. See LICENSE.txt in the project root for license information.

namespace Masa.BuildingBlocks.StackSdks.Auth.Contracts.Model;

public class UserModel
{
    public Guid Id { get; set; }

    public string? Name { get; set; }

    public string DisplayName { get; set; }

    public string? StaffDisplayName { get; set; }

    public string Account { get; set; }

    public GenderTypes Gender { get; set; }

    public string Avatar { get; set; }

    public string? IdCard { get; set; }

    public string? PhoneNumber { get; set; }

    public string? Email { get; set; }

    public string? CompanyName { get; set; }

    public string? Department { get; set; }

    public string? Position { get; set; }

    public bool Enabled { get; set; } = true;

    public bool IsDeleted { get; set; }

    public AddressValueModel Address { get; set; } = new();

    public List<RoleModel> Roles { get; set; } = new();

    public List<SubjectPermissionRelationModel> Permissions { get; set; } = new();

    public Guid? StaffId { get; set; }

    //only for staff
    public Guid? CurrentTeamId { get; set; }

    public DateTime CreationTime { get; set; }

    public UserModel()
    {
        Avatar = "";
        Account = "";
    }

    public UserModel(
        Guid id,
        string? name,
        string displayName,
        string staffDisplayName,
        string account,
        GenderTypes gender,
        string avatar,
        string? idCard,
        string? phoneNumber,
        string? email,
        string? companyName,
        string? department,
        string? position,
        AddressValueModel address)
    {
        Id = id;
        Name = name;
        DisplayName = displayName;
        StaffDisplayName = staffDisplayName;
        Account = account;
        Gender = gender;
        Avatar = avatar;
        IdCard = idCard;
        PhoneNumber = phoneNumber;
        Email = email;
        CompanyName = companyName;
        Department = department;
        Position = position;
        Address = address;
    }
}

