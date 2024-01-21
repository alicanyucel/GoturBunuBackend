using GoturBunu.Domain.Entities.Identity;

namespace GoturBunu.Application.Security
{
    public static class Security
    {
        public static List<string> GetAllPermissions()
        {
            return typeof(AssemblyReference).Assembly.GetTypes()
                .Where(t => t.IsClass && t.GetInterface(nameof(IPermission)) != null)
                .Select(t => t.Name)
                .ToList();
        }
        public static List<string> GetCarrierPermissions()
        {
            return typeof(AssemblyReference).Assembly.GetTypes()
                .Where(t => t.IsClass && t.GetInterface(nameof(ICarrierPermission)) != null)
                .Select(t => t.Name)
                .ToList();
        }
        public static List<string> GetStorePermissions()
        {
            return typeof(AssemblyReference).Assembly.GetTypes()
                .Where(t => t.IsClass && t.GetInterface(nameof(IStorePermission)) != null)
                .Select(t => t.Name)
                .ToList();
        }
    }

    public class BuiltInRoles
    {
        public static readonly Role Admin = new Role
        {
            Id = "9cf20d1a-9a51-4918-bd1b-29b972057fbf",
            Name = "Admin",
            NormalizedName = "ADMIN",
            ConcurrencyStamp = "c795b65b-5a02-4365-960c-7330c9626c2e"
        };
        public static readonly Role Store = new Role
        {
            Id = "0bd95914-44ff-4f4d-bf02-e083d77b75fa",
            Name = "Store",
            NormalizedName = "STORE",
            ConcurrencyStamp = "4579862a-75c6-4974-afa3-370fa827b876"
        };
        public static readonly Role Carrier = new Role
        {
            Id = "fb7ac2d9-b240-4d91-a2c9-d70072cefc64",
            Name = "Carrier",
            NormalizedName = "CARRIER",
            ConcurrencyStamp = "5e4dccab-eedd-4800-a750-f27d2093282b"
        };
    }

    public class BuiltInUsers
    {
        public static readonly User Admin = new User()
        {
            Id = "0ffadff6-2bf5-4edf-be29-12cfe656edf3",
            UserName = "admin",
            NormalizedUserName = "ADMIN",
            Email = "admin@goturbunu.com",
            NormalizedEmail = "ADMIN@GOTURBUNU.COM",
            PasswordHash = "AQAAAAEAAC7gAAAAEBK2NqcIbdVmeEtwpc9MUpHux9pscMSJoncY3Acwzomjpi322ZkZtLTbwrRDta7eLA==", // Qwq1234.
            EmailConfirmed = false,
            SecurityStamp = "QPZ2ADTAD5UKI7J5OACQI2HULBVCLPQI",
            ConcurrencyStamp = "0320320e-a3e3-457b-8a74-188d4f16fefb",
            LockoutEnabled = true
        };

        public static readonly User Store = new User()
        {
            Id = "36125b81-d8c6-4665-9c2f-ec95db4e8eac",
            UserName = "store",
            NormalizedUserName = "STORE",
            Email = "store@goturbunu.com",
            NormalizedEmail = "STORE@GOTURBUNU.COM",
            PasswordHash = "AQAAAAEAAC7gAAAAEBK2NqcIbdVmeEtwpc9MUpHux9pscMSJoncY3Acwzomjpi322ZkZtLTbwrRDta7eLA==", // Qwq1234.
            EmailConfirmed = false,
            SecurityStamp = "QPZ2ADTAD5UKI7J5OACQI2HULBVCLPQI",
            ConcurrencyStamp = "0320320e-a3e3-457b-8a74-188d4f16fefb",
            LockoutEnabled = true
        };

        public static readonly User Carrier = new User()
        {
            Id = "05132bcb-2752-4c5b-87f7-3d884e420df4",
            UserName = "carrier",
            NormalizedUserName = "CARRIER",
            Email = "carrier@goturbunu.com",
            NormalizedEmail = "CARRIER@GOTURBUNU.COM",
            PasswordHash = "AQAAAAEAAC7gAAAAEBK2NqcIbdVmeEtwpc9MUpHux9pscMSJoncY3Acwzomjpi322ZkZtLTbwrRDta7eLA==", // Qwq1234.
            EmailConfirmed = false,
            SecurityStamp = "QPZ2ADTAD5UKI7J5OACQI2HULBVCLPQI",
            ConcurrencyStamp = "0320320e-a3e3-457b-8a74-188d4f16fefb",
            LockoutEnabled = true
        };

        public static readonly User Carrier_1 = new User()
        {
            Id = "238160d0-8a4b-4553-85e6-110290ff6878",
            UserName = "carrier1",
            NormalizedUserName = "CARRIER1",
            Email = "carrier1@goturbunu.com",
            NormalizedEmail = "CARRIER1@GOTURBUNU.COM",
            PasswordHash = "AQAAAAEAAC7gAAAAEBK2NqcIbdVmeEtwpc9MUpHux9pscMSJoncY3Acwzomjpi322ZkZtLTbwrRDta7eLA==", // Qwq1234.
            EmailConfirmed = false,
            SecurityStamp = "QPZ2ADTAD5UKI7J5OACQI2HULBVCLPQI",
            ConcurrencyStamp = "0320320e-a3e3-457b-8a74-188d4f16fefb",
            LockoutEnabled = true
        };

        public static readonly User Carrier_2 = new User()
        {
            Id = "0b290621-72de-4825-9f31-c510664d4ca9",
            UserName = "carrier2",
            NormalizedUserName = "CARRIER2",
            Email = "carrier2@goturbunu.com",
            NormalizedEmail = "CARRIER2@GOTURBUNU.COM",
            PasswordHash = "AQAAAAEAAC7gAAAAEBK2NqcIbdVmeEtwpc9MUpHux9pscMSJoncY3Acwzomjpi322ZkZtLTbwrRDta7eLA==", // Qwq1234.
            EmailConfirmed = false,
            SecurityStamp = "QPZ2ADTAD5UKI7J5OACQI2HULBVCLPQI",
            ConcurrencyStamp = "0320320e-a3e3-457b-8a74-188d4f16fefb",
            LockoutEnabled = true
        };

        public static readonly User Carrier_3 = new User()
        {
            Id = "541afee1-ccf5-426b-9ed7-cc8087a3d00b",
            UserName = "carrier3",
            NormalizedUserName = "CARRIER3",
            Email = "carrier3@goturbunu.com",
            NormalizedEmail = "CARRIER3@GOTURBUNU.COM",
            PasswordHash = "AQAAAAEAAC7gAAAAEBK2NqcIbdVmeEtwpc9MUpHux9pscMSJoncY3Acwzomjpi322ZkZtLTbwrRDta7eLA==", // Qwq1234.
            EmailConfirmed = false,
            SecurityStamp = "QPZ2ADTAD5UKI7J5OACQI2HULBVCLPQI",
            ConcurrencyStamp = "0320320e-a3e3-457b-8a74-188d4f16fefb",
            LockoutEnabled = true
        };

        public static readonly User Carrier_4 = new User()
        {
            Id = "64c40294-ef97-4354-aa2c-c95d4ca61267",
            UserName = "carrier4",
            NormalizedUserName = "CARRIER4",
            Email = "carrier4@goturbunu.com",
            NormalizedEmail = "CARRIER4@GOTURBUNU.COM",
            PasswordHash = "AQAAAAEAAC7gAAAAEBK2NqcIbdVmeEtwpc9MUpHux9pscMSJoncY3Acwzomjpi322ZkZtLTbwrRDta7eLA==", // Qwq1234.
            EmailConfirmed = false,
            SecurityStamp = "QPZ2ADTAD5UKI7J5OACQI2HULBVCLPQI",
            ConcurrencyStamp = "0320320e-a3e3-457b-8a74-188d4f16fefb",
            LockoutEnabled = true
        };

        public static readonly User Carrier_5 = new User()
        {
            Id = "bf67c7fc-2e77-4e96-a08f-a930345c2150",
            UserName = "carrier5",
            NormalizedUserName = "CARRIER5",
            Email = "carrier5@goturbunu.com",
            NormalizedEmail = "CARRIER5@GOTURBUNU.COM",
            PasswordHash = "AQAAAAEAAC7gAAAAEBK2NqcIbdVmeEtwpc9MUpHux9pscMSJoncY3Acwzomjpi322ZkZtLTbwrRDta7eLA==", // Qwq1234.
            EmailConfirmed = false,
            SecurityStamp = "QPZ2ADTAD5UKI7J5OACQI2HULBVCLPQI",
            ConcurrencyStamp = "0320320e-a3e3-457b-8a74-188d4f16fefb",
            LockoutEnabled = true
        };

        public static readonly User Carrier_6 = new User()
        {
            Id = "95defd0e-26a7-4c60-b5ab-79ba66a7f788",
            UserName = "carrier6",
            NormalizedUserName = "CARRIER6",
            Email = "carrier6@goturbunu.com",
            NormalizedEmail = "CARRIER6@GOTURBUNU.COM",
            PasswordHash = "AQAAAAEAAC7gAAAAEBK2NqcIbdVmeEtwpc9MUpHux9pscMSJoncY3Acwzomjpi322ZkZtLTbwrRDta7eLA==", // Qwq1234.
            EmailConfirmed = false,
            SecurityStamp = "QPZ2ADTAD5UKI7J5OACQI2HULBVCLPQI",
            ConcurrencyStamp = "0320320e-a3e3-457b-8a74-188d4f16fefb",
            LockoutEnabled = true
        };

        public static readonly User Carrier_7 = new User()
        {
            Id = "adeb25b4-4fd7-41cf-9cae-f6698febbbea",
            UserName = "carrier7",
            NormalizedUserName = "CARRIER7",
            Email = "carrier7@goturbunu.com",
            NormalizedEmail = "CARRIER7@GOTURBUNU.COM",
            PasswordHash = "AQAAAAEAAC7gAAAAEBK2NqcIbdVmeEtwpc9MUpHux9pscMSJoncY3Acwzomjpi322ZkZtLTbwrRDta7eLA==", // Qwq1234.
            EmailConfirmed = false,
            SecurityStamp = "QPZ2ADTAD5UKI7J5OACQI2HULBVCLPQI",
            ConcurrencyStamp = "0320320e-a3e3-457b-8a74-188d4f16fefb",
            LockoutEnabled = true
        };

        public static readonly User Carrier_8 = new User()
        {
            Id = "9905504a-d071-440f-96ad-3d3ddf38c248",
            UserName = "carrier8",
            NormalizedUserName = "CARRIER8",
            Email = "carrier8@goturbunu.com",
            NormalizedEmail = "CARRIER8@GOTURBUNU.COM",
            PasswordHash = "AQAAAAEAAC7gAAAAEBK2NqcIbdVmeEtwpc9MUpHux9pscMSJoncY3Acwzomjpi322ZkZtLTbwrRDta7eLA==", // Qwq1234.
            EmailConfirmed = false,
            SecurityStamp = "QPZ2ADTAD5UKI7J5OACQI2HULBVCLPQI",
            ConcurrencyStamp = "0320320e-a3e3-457b-8a74-188d4f16fefb",
            LockoutEnabled = true
        };

        public static readonly User Carrier_9 = new User()
        {
            Id = "66d9e051-4961-4aad-9408-eef68716411b",
            UserName = "carrier9",
            NormalizedUserName = "CARRIER9",
            Email = "carrier9@goturbunu.com",
            NormalizedEmail = "CARRIER9@GOTURBUNU.COM",
            PasswordHash = "AQAAAAEAAC7gAAAAEBK2NqcIbdVmeEtwpc9MUpHux9pscMSJoncY3Acwzomjpi322ZkZtLTbwrRDta7eLA==", // Qwq1234.
            EmailConfirmed = false,
            SecurityStamp = "QPZ2ADTAD5UKI7J5OACQI2HULBVCLPQI",
            ConcurrencyStamp = "0320320e-a3e3-457b-8a74-188d4f16fefb",
            LockoutEnabled = true
        };

        public static readonly User Carrier_10 = new User()
        {
            Id = "f50590d5-1f85-4f6c-93c8-ec17aebe31b0",
            UserName = "carrier10",
            NormalizedUserName = "CARRIER10",
            Email = "carrier10@goturbunu.com",
            NormalizedEmail = "CARRIER10@GOTURBUNU.COM",
            PasswordHash = "AQAAAAEAAC7gAAAAEBK2NqcIbdVmeEtwpc9MUpHux9pscMSJoncY3Acwzomjpi322ZkZtLTbwrRDta7eLA==", // Qwq1234.
            EmailConfirmed = false,
            SecurityStamp = "QPZ2ADTAD5UKI7J5OACQI2HULBVCLPQI",
            ConcurrencyStamp = "0320320e-a3e3-457b-8a74-188d4f16fefb",
            LockoutEnabled = true
        };
    }

    public class BuiltInUserRoles
    {
        public static readonly UserRole Admin = new UserRole()
        {
            UserId = BuiltInUsers.Admin.Id,
            RoleId = BuiltInRoles.Admin.Id
        };

        public static readonly UserRole Store = new UserRole()
        {
            UserId = BuiltInUsers.Store.Id,
            RoleId = BuiltInRoles.Store.Id
        };

        public static readonly UserRole Carrier = new UserRole()
        {
            UserId = BuiltInUsers.Carrier.Id,
            RoleId = BuiltInRoles.Carrier.Id
        };

        public static readonly UserRole Carrier_1 = new UserRole()
        {
            UserId = BuiltInUsers.Carrier_1.Id,
            RoleId = BuiltInRoles.Carrier.Id
        };

        public static readonly UserRole Carrier_2 = new UserRole()
        {
            UserId = BuiltInUsers.Carrier_2.Id,
            RoleId = BuiltInRoles.Carrier.Id
        };

        public static readonly UserRole Carrier_3 = new UserRole()
        {
            UserId = BuiltInUsers.Carrier_3.Id,
            RoleId = BuiltInRoles.Carrier.Id
        };

        public static readonly UserRole Carrier_4 = new UserRole()
        {
            UserId = BuiltInUsers.Carrier_4.Id,
            RoleId = BuiltInRoles.Carrier.Id
        };

        public static readonly UserRole Carrier_5 = new UserRole()
        {
            UserId = BuiltInUsers.Carrier_5.Id,
            RoleId = BuiltInRoles.Carrier.Id
        };

        public static readonly UserRole Carrier_6 = new UserRole()
        {
            UserId = BuiltInUsers.Carrier_6.Id,
            RoleId = BuiltInRoles.Carrier.Id
        };

        public static readonly UserRole Carrier_7 = new UserRole()
        {
            UserId = BuiltInUsers.Carrier_7.Id,
            RoleId = BuiltInRoles.Carrier.Id
        };

        public static readonly UserRole Carrier_8 = new UserRole()
        {
            UserId = BuiltInUsers.Carrier_8.Id,
            RoleId = BuiltInRoles.Carrier.Id
        };

        public static readonly UserRole Carrier_9 = new UserRole()
        {
            UserId = BuiltInUsers.Carrier_9.Id,
            RoleId = BuiltInRoles.Carrier.Id
        };

        public static readonly UserRole Carrier_10 = new UserRole()
        {
            UserId = BuiltInUsers.Carrier_10.Id,
            RoleId = BuiltInRoles.Carrier.Id
        };
    }
}
