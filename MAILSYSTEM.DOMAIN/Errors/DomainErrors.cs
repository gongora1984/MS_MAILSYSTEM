using MAILSYSTEM.DOMAIN.Shared;

namespace MAILSYSTEM.DOMAIN.Errors;

public static class DomainErrors
{
    public static class Company
    {
        public static readonly Error CompanyNameInUse = new(
            "Company.CompanyName",
            "The specified company name is already in use");

        public static readonly Error CompanyUsernameInUse = new(
            "Company.CompanyUsername",
            "The specified company username is already in use");

        public static readonly Func<Guid, Error> NotFound = id => new Error(
            "Company.Id",
            $"The company with the identifier {id} was not found.");

        public static readonly Func<string, Error> NotFoundByName = name => new Error(
            "Company.CompanyName",
            $"The company with the identifier {name} was not found.");

        public static readonly Error InvalidUsername = new(
            "Company.CompanyUsername",
            "The provided username is invalid");

        public static readonly Error InvalidCredentials = new(
            "Company.CompanyPassword",
            "The provided credentials are invalid");
    }

    public static class ListItem
    {
        public static readonly Error SystemCategoryInUse = new(
            "ListItem.SystemCategory",
            "The specified system category is already in use");

        public static readonly Error SystemTagInUse = new(
            "ListItem.SystemTag",
            "The specified system tag under that category is already in use");

        public static readonly Error SystemCategoryTagDisplayInUse = new(
            "ListItem.SystemCategory, ListItem.SystemTag, ListItem.ListItemDisplayText",
            "The specified category, tag and display text is already in use");

        public static readonly Func<Guid, Error> NotFound = id => new Error(
            "ListItem.Id",
            $"The list item with the identifier {id} was not found.");
    }

    public static class State
    {
        public static readonly Func<Guid, Error> NotFound = id => new Error(
            "State.Id",
            $"The state with the identifier {id} was not found.");

        public static readonly Func<string, Error> NotFoundByName = name => new Error(
            "State.StateDescription",
            $"The state with the name {name} was not found.");

        public static readonly Func<string, Error> NotFoundByNameBilling = name => new Error(
            "State.StateDescription",
            $"The billing state with the name {name} was not found.");

        public static readonly Func<string, Error> NotFoundByNameReturn = name => new Error(
            "State.StateDescription",
            $"The return state with the name {name} was not found.");

        public static readonly Func<string, Error> NotFoundByAbbreviation = name => new Error(
            "State.StateAbbreviation",
            $"The state with the abbreviation {name} was not found.");

        public static readonly Func<string, Error> NotFoundByAbbreviationBilling = name => new Error(
            "State.StateAbbreviation",
            $"The billing state with the abbreviation {name} was not found.");

        public static readonly Func<string, Error> NotFoundByAbbreviationReturn = name => new Error(
            "State.StateAbbreviation",
            $"The return state with the abbreviation {name} was not found.");

        public static readonly Error StateNameInUse = new(
           "State.StateDescription",
           "The specified name is already in use");

        public static readonly Error StateAbbreviationInUse = new(
           "State.StateAbbreviation",
           "The specified abbreviation is already in use");
    }
}
