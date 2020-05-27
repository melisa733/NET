using Microsoft.AspNetCore.Http;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebShopWithLayOut
{
    public static class SessionExtensions
    {
        public static void SetUserName(this ISession session, string username)
        {
            session.SetString("username", username);
        }

        public static void SetEmail(this ISession session, string email)
        {
            session.SetString("email", email);
        }

        public static string GetUserName(this ISession session)
        {
            return session.GetString("username");
        }

        public static string GetEmail(this ISession session)
        {
            return session.GetString("email");
        }
    }
}