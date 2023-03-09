﻿namespace MAILSYSTEM.DOMAIN.Contracts.Requests;

public record RegisterCompanyRequest(
    string companyName,
    string companyUsername,
    string companyPassword,
    string companyAddress1,
    string? companyAddress2,
    string companyCity,
    string companyState,
    string companyZip,
    string? companyPhone,
    string? companyFax,
    string companyEmail,
    string companyBillingAddress1,
    string? companyBillingAddress2,
    string companyBillingCity,
    string companyBillingState,
    string companyBillingZip,
    string companyReturnName,
    string companyReturnAddress1,
    string? companyReturnAddress2,
    string companyReturnCity,
    string companyReturnState,
    string companyReturnZip,
    string companyReturnEmailAddress,
    string? companyDefaultFilePathLocation);
