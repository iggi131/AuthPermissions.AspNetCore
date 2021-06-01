﻿// Copyright (c) 2021 Jon P Smith, GitHub: JonPSmith, web: http://www.thereformedprogrammer.net/
// Licensed under MIT license. See License.txt in the project root for license information.

namespace AuthPermissions.DataLayer.Classes.SupportTypes
{
    public static class AuthDbConstants
    {
        public const int UserIdSize = 256; //must be below 900 bytes because it has a unique index

        public const int UserNameSize = 128;

        public const int RoleNameSize = 100;

        public const int TenantNameSize = 100;

        public const int DataKeySize = 64;
    }
}