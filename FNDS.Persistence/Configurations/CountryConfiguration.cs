﻿using FDNS.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FNDS.Persistence.Configurations
{
    public class CountryConfiguration : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.HasKey(x => x.Id).IsClustered();

            builder.Property(c => c.FullName).HasMaxLength(50).IsRequired(true);
            builder.Property(c => c.Code).HasMaxLength(2).IsFixedLength(true).IsRequired(true);

            builder.HasIndex(c => c.Code).IsClustered(false).IsUnique();
            builder.HasIndex(c => c.FullName).IsClustered(false).IsUnique();

            ushort cnt = 1;
            builder.HasData(
                new Country { Id = cnt++, FullName = "Afghanistan", Code = "AF" },
                new Country { Id = cnt++, FullName = "Albania", Code = "AL" },
                new Country { Id = cnt++, FullName = "Algeria", Code = "DZ" },
                new Country { Id = cnt++, FullName = "American Samoa", Code = "AS" },
                new Country { Id = cnt++, FullName = "Andorra", Code = "AD" },
                new Country { Id = cnt++, FullName = "Angola", Code = "AO" },
                new Country { Id = cnt++, FullName = "Anguilla", Code = "AI" },
                new Country { Id = cnt++, FullName = "Antarctica", Code = "AQ" },
                new Country { Id = cnt++, FullName = "Antigua and Barbuda", Code = "AG" },
                new Country { Id = cnt++, FullName = "Argentina", Code = "AR" },
                new Country { Id = cnt++, FullName = "Armenia", Code = "AM" },
                new Country { Id = cnt++, FullName = "Aruba", Code = "AW" },
                new Country { Id = cnt++, FullName = "Australia", Code = "AU" },
                new Country { Id = cnt++, FullName = "Austria", Code = "AT" },
                new Country { Id = cnt++, FullName = "Azerbaijan", Code = "AZ" },
                new Country { Id = cnt++, FullName = "Bahamas", Code = "BS" },
                new Country { Id = cnt++, FullName = "Bahrain", Code = "BH" },
                new Country { Id = cnt++, FullName = "Bangladesh", Code = "BD" },
                new Country { Id = cnt++, FullName = "Barbados", Code = "BB" },
                new Country { Id = cnt++, FullName = "Belarus", Code = "BY" },
                new Country { Id = cnt++, FullName = "Belgium", Code = "BE" },
                new Country { Id = cnt++, FullName = "Belize", Code = "BZ" },
                new Country { Id = cnt++, FullName = "Benin", Code = "BJ" },
                new Country { Id = cnt++, FullName = "Bermuda", Code = "BM" },
                new Country { Id = cnt++, FullName = "Bhutan", Code = "BT" },
                new Country { Id = cnt++, FullName = "Bolivia", Code = "BO" },
                new Country { Id = cnt++, FullName = "Bosnia and Herzegovina", Code = "BA" },
                new Country { Id = cnt++, FullName = "Botswana", Code = "BW" },
                new Country { Id = cnt++, FullName = "Bouvet Island", Code = "BV" },
                new Country { Id = cnt++, FullName = "Brazil", Code = "BR" },
                new Country { Id = cnt++, FullName = "Brunei Darussalam", Code = "BN" },
                new Country { Id = cnt++, FullName = "Bulgaria", Code = "BG" },
                new Country { Id = cnt++, FullName = "Burkina Faso", Code = "BF" },
                new Country { Id = cnt++, FullName = "Burundi", Code = "BI" },
                new Country { Id = cnt++, FullName = "Cambodia", Code = "KH" },
                new Country { Id = cnt++, FullName = "Cameroon", Code = "CM" },
                new Country { Id = cnt++, FullName = "Canada", Code = "CA" },
                new Country { Id = cnt++, FullName = "Cape Verde", Code = "CV" },
                new Country { Id = cnt++, FullName = "Cayman Islands", Code = "KY" },
                new Country { Id = cnt++, FullName = "Central African Republic", Code = "CF" },
                new Country { Id = cnt++, FullName = "Chad", Code = "TD" },
                new Country { Id = cnt++, FullName = "Chile", Code = "CL" },
                new Country { Id = cnt++, FullName = "China", Code = "CN" },
                new Country { Id = cnt++, FullName = "Christmas Island", Code = "CX" },
                new Country { Id = cnt++, FullName = "Cocos Islands", Code = "CC" },
                new Country { Id = cnt++, FullName = "Colombia", Code = "CO" },
                new Country { Id = cnt++, FullName = "Comoros", Code = "KM" },
                new Country { Id = cnt++, FullName = "Congo", Code = "CD" },
                new Country { Id = cnt++, FullName = "Cook Islands", Code = "CK" },
                new Country { Id = cnt++, FullName = "Costa Rica", Code = "CR" },
                new Country { Id = cnt++, FullName = "Cote D'Ivoire", Code = "CI" },
                new Country { Id = cnt++, FullName = "Croatia", Code = "HR" },
                new Country { Id = cnt++, FullName = "Curacao", Code = "CW" },
                new Country { Id = cnt++, FullName = "Cyprus", Code = "CY" },
                new Country { Id = cnt++, FullName = "Czech Republic", Code = "CZ" },
                new Country { Id = cnt++, FullName = "Denmark", Code = "DK" },
                new Country { Id = cnt++, FullName = "Djibouti", Code = "DJ" },
                new Country { Id = cnt++, FullName = "Dominica", Code = "DM" },
                new Country { Id = cnt++, FullName = "Dominican Republic", Code = "DO" },
                new Country { Id = cnt++, FullName = "East Timor", Code = "TL" },
                new Country { Id = cnt++, FullName = "Ecuador", Code = "EC" },
                new Country { Id = cnt++, FullName = "Egypt", Code = "EG" },
                new Country { Id = cnt++, FullName = "El Salvador", Code = "SV" },
                new Country { Id = cnt++, FullName = "Equatorial Guinea", Code = "CQ" },
                new Country { Id = cnt++, FullName = "Eritrea", Code = "ER" },
                new Country { Id = cnt++, FullName = "Estonia", Code = "EE" },
                new Country { Id = cnt++, FullName = "Ethiopia", Code = "ET" },
                new Country { Id = cnt++, FullName = "Falkland Islands", Code = "FK" },
                new Country { Id = cnt++, FullName = "Faroe Islands", Code = "FO" },
                new Country { Id = cnt++, FullName = "Fiji", Code = "FJ" },
                new Country { Id = cnt++, FullName = "Finland", Code = "FI" },
                new Country { Id = cnt++, FullName = "France", Code = "FR" },
                new Country { Id = cnt++, FullName = "French Guiana", Code = "GF" },
                new Country { Id = cnt++, FullName = "French Polynesia", Code = "PF" },
                new Country { Id = cnt++, FullName = "Gabon", Code = "GA" },
                new Country { Id = cnt++, FullName = "Gambia", Code = "GM" },
                new Country { Id = cnt++, FullName = "Georgia", Code = "GE" },
                new Country { Id = cnt++, FullName = "Germany", Code = "DE" },
                new Country { Id = cnt++, FullName = "Ghana", Code = "GH" },
                new Country { Id = cnt++, FullName = "Gibraltar", Code = "GI" },
                new Country { Id = cnt++, FullName = "Greece", Code = "GR" },
                new Country { Id = cnt++, FullName = "Greenland", Code = "GL" },
                new Country { Id = cnt++, FullName = "Grenada", Code = "GD" },
                new Country { Id = cnt++, FullName = "Guadeloupe", Code = "GP" },
                new Country { Id = cnt++, FullName = "Guam", Code = "GU" },
                new Country { Id = cnt++, FullName = "Guatemala", Code = "GT" },
                new Country { Id = cnt++, FullName = "Guernsey", Code = "GG" },
                new Country { Id = cnt++, FullName = "Guinea", Code = "GN" },
                new Country { Id = cnt++, FullName = "Guinea-Bissau", Code = "GW" },
                new Country { Id = cnt++, FullName = "Guyana", Code = "GY" },
                new Country { Id = cnt++, FullName = "Haiti", Code = "HT" },
                new Country { Id = cnt++, FullName = "Honduras", Code = "HN" },
                new Country { Id = cnt++, FullName = "Hong Kong", Code = "HK" },
                new Country { Id = cnt++, FullName = "Hungary", Code = "HU" },
                new Country { Id = cnt++, FullName = "Iceland", Code = "IS" },
                new Country { Id = cnt++, FullName = "India", Code = "IN" },
                new Country { Id = cnt++, FullName = "Indonesia", Code = "ID" },
                new Country { Id = cnt++, FullName = "Iraq", Code = "IR" },
                new Country { Id = cnt++, FullName = "Ireland", Code = "IE" },
                new Country { Id = cnt++, FullName = "Isle of Man", Code = "IM" },
                new Country { Id = cnt++, FullName = "Israel", Code = "IL" },
                new Country { Id = cnt++, FullName = "Italy", Code = "IT" },
                new Country { Id = cnt++, FullName = "Japan", Code = "JP" },
                new Country { Id = cnt++, FullName = "Jersey", Code = "JE" },
                new Country { Id = cnt++, FullName = "Jordan", Code = "JO" },
                new Country { Id = cnt++, FullName = "Kazakhstan", Code = "KZ" },
                new Country { Id = cnt++, FullName = "Kenya", Code = "KE" },
                new Country { Id = cnt++, FullName = "Kiribati", Code = "KI" },
                new Country { Id = cnt++, FullName = "Kuwait", Code = "KW" },
                new Country { Id = cnt++, FullName = "Kyrgyzstan", Code = "KG" },
                new Country { Id = cnt++, FullName = "Laos", Code = "LA" },
                new Country { Id = cnt++, FullName = "Latvia", Code = "LV" },
                new Country { Id = cnt++, FullName = "Lebanon", Code = "LB" },
                new Country { Id = cnt++, FullName = "Lesotho", Code = "LS" },
                new Country { Id = cnt++, FullName = "Liberia", Code = "LR" },
                new Country { Id = cnt++, FullName = "Libya", Code = "LY" },
                new Country { Id = cnt++, FullName = "Liechtenstein", Code = "LI" },
                new Country { Id = cnt++, FullName = "Lithuania", Code = "LT" },
                new Country { Id = cnt++, FullName = "Luxembourg", Code = "LU" },
                new Country { Id = cnt++, FullName = "Macau", Code = "MO" },
                new Country { Id = cnt++, FullName = "Macedonia", Code = "MK" },
                new Country { Id = cnt++, FullName = "Madagascar", Code = "MG" },
                new Country { Id = cnt++, FullName = "Malawi", Code = "MW" },
                new Country { Id = cnt++, FullName = "Malaysia", Code = "MY" },
                new Country { Id = cnt++, FullName = "Maldives", Code = "MV" },
                new Country { Id = cnt++, FullName = "Mali", Code = "ML" },
                new Country { Id = cnt++, FullName = "Malta", Code = "MT" },
                new Country { Id = cnt++, FullName = "Marshall Islands", Code = "MH" },
                new Country { Id = cnt++, FullName = "Martinique", Code = "MQ" },
                new Country { Id = cnt++, FullName = "Mauritania", Code = "MR" },
                new Country { Id = cnt++, FullName = "Mauritius", Code = "MU" },
                new Country { Id = cnt++, FullName = "Mayotte", Code = "YT" },
                new Country { Id = cnt++, FullName = "Mexico", Code = "MX" },
                new Country { Id = cnt++, FullName = "Micronesia", Code = "FM" },
                new Country { Id = cnt++, FullName = "Moldova", Code = "MD" },
                new Country { Id = cnt++, FullName = "Monaco", Code = "MC" },
                new Country { Id = cnt++, FullName = "Mongolia", Code = "MN" },
                new Country { Id = cnt++, FullName = "Montenegro", Code = "ME" },
                new Country { Id = cnt++, FullName = "Montserrat", Code = "MS" },
                new Country { Id = cnt++, FullName = "Morocco", Code = "MA" },
                new Country { Id = cnt++, FullName = "Mozambique", Code = "MZ" },
                new Country { Id = cnt++, FullName = "Myanmar", Code = "MM" },
                new Country { Id = cnt++, FullName = "Namibia", Code = "NA" },
                new Country { Id = cnt++, FullName = "Nauru", Code = "NR" },
                new Country { Id = cnt++, FullName = "Nepal", Code = "NP" },
                new Country { Id = cnt++, FullName = "Netherlands", Code = "NL" },
                new Country { Id = cnt++, FullName = "Netherlands Antilles", Code = "AN" },
                new Country { Id = cnt++, FullName = "New Caledonia", Code = "NC" },
                new Country { Id = cnt++, FullName = "New Zealand", Code = "NZ" },
                new Country { Id = cnt++, FullName = "Nicaragua", Code = "NI" },
                new Country { Id = cnt++, FullName = "Niger", Code = "NE" },
                new Country { Id = cnt++, FullName = "Nigeria", Code = "NG" },
                new Country { Id = cnt++, FullName = "Niue", Code = "NU" },
                new Country { Id = cnt++, FullName = "Norfolk Island", Code = "NF" },
                new Country { Id = cnt++, FullName = "Northern Mariana Isls", Code = "MP" },
                new Country { Id = cnt++, FullName = "Norway", Code = "NO" },
                new Country { Id = cnt++, FullName = "Oman", Code = "OM" },
                new Country { Id = cnt++, FullName = "Pakistan", Code = "PK" },
                new Country { Id = cnt++, FullName = "Palau", Code = "PW" },
                new Country { Id = cnt++, FullName = "Papua New Guinea", Code = "PG" },
                new Country { Id = cnt++, FullName = "Paraguay", Code = "PY" },
                new Country { Id = cnt++, FullName = "Peru", Code = "PE" },
                new Country { Id = cnt++, FullName = "Philippines", Code = "PH" },
                new Country { Id = cnt++, FullName = "Pitcairn", Code = "PN" },
                new Country { Id = cnt++, FullName = "Poland", Code = "PL" },
                new Country { Id = cnt++, FullName = "Portugal", Code = "PT" },
                new Country { Id = cnt++, FullName = "Puerto Rico", Code = "PR" },
                new Country { Id = cnt++, FullName = "Qatar", Code = "QA" },
                new Country { Id = cnt++, FullName = "Reunion", Code = "RE" },
                new Country { Id = cnt++, FullName = "Romania", Code = "RO" },
                new Country { Id = cnt++, FullName = "Rwanda", Code = "RW" },
                new Country { Id = cnt++, FullName = "Saint Kitts and Nevis", Code = "KN" },
                new Country { Id = cnt++, FullName = "Saint Lucia", Code = "LC" },
                new Country { Id = cnt++, FullName = "Samoa", Code = "WS" },
                new Country { Id = cnt++, FullName = "San Marino", Code = "SM" },
                new Country { Id = cnt++, FullName = "Sao Tome and Principe", Code = "ST" },
                new Country { Id = cnt++, FullName = "Saudi Arabia", Code = "SA" },
                new Country { Id = cnt++, FullName = "Senegal", Code = "SN" },
                new Country { Id = cnt++, FullName = "Serbia", Code = "RS" },
                new Country { Id = cnt++, FullName = "Seychelles", Code = "SC" },
                new Country { Id = cnt++, FullName = "Sierra Leone", Code = "SL" },
                new Country { Id = cnt++, FullName = "Singapore", Code = "SG" },
                new Country { Id = cnt++, FullName = "Slovak Republic", Code = "SK" },
                new Country { Id = cnt++, FullName = "Slovenia", Code = "SI" },
                new Country { Id = cnt++, FullName = "Solomon Islands", Code = "SB" },
                new Country { Id = cnt++, FullName = "Somalia", Code = "SO" },
                new Country { Id = cnt++, FullName = "South Africa", Code = "ZA" },
                new Country { Id = cnt++, FullName = "South Korea", Code = "KR" },
                new Country { Id = cnt++, FullName = "Spain", Code = "ES" },
                new Country { Id = cnt++, FullName = "Sri Lanka", Code = "LK" },
                new Country { Id = cnt++, FullName = "St. Vincent", Code = "VC" },
                new Country { Id = cnt++, FullName = "St. Helena", Code = "SH" },
                new Country { Id = cnt++, FullName = "St. Pierre and Miquelon", Code = "PM" },
                new Country { Id = cnt++, FullName = "Suriname", Code = "SR" },
                new Country { Id = cnt++, FullName = "Swaziland", Code = "SZ" },
                new Country { Id = cnt++, FullName = "Sweden", Code = "SE" },
                new Country { Id = cnt++, FullName = "Switzerland", Code = "CH" },
                new Country { Id = cnt++, FullName = "Taiwan", Code = "TW" },
                new Country { Id = cnt++, FullName = "Tajikistan", Code = "TJ" },
                new Country { Id = cnt++, FullName = "Tanzania", Code = "TZ" },
                new Country { Id = cnt++, FullName = "Thailand", Code = "TH" },
                new Country { Id = cnt++, FullName = "Togo", Code = "TG" },
                new Country { Id = cnt++, FullName = "Tokelau", Code = "TK" },
                new Country { Id = cnt++, FullName = "Tonga", Code = "TO" },
                new Country { Id = cnt++, FullName = "Trinidad and Tobago", Code = "TT" },
                new Country { Id = cnt++, FullName = "Tunisia", Code = "TN" },
                new Country { Id = cnt++, FullName = "Turkey", Code = "TR" },
                new Country { Id = cnt++, FullName = "Turkmenistan", Code = "TM" },
                new Country { Id = cnt++, FullName = "Turks and Caicos Islands", Code = "TC" },
                new Country { Id = cnt++, FullName = "Tuvalu", Code = "TV" },
                new Country { Id = cnt++, FullName = "Uganda", Code = "UG" },
                new Country { Id = cnt++, FullName = "Ukraine", Code = "UA" },
                new Country { Id = cnt++, FullName = "United Arab Emirates", Code = "AE" },
                new Country { Id = cnt++, FullName = "United Kingdom", Code = "GB" },
                new Country { Id = cnt++, FullName = "United States", Code = "US" },
                new Country { Id = cnt++, FullName = "Uruguay", Code = "UY" },
                new Country { Id = cnt++, FullName = "Uzbekistan", Code = "UZ" },
                new Country { Id = cnt++, FullName = "Vanuatu", Code = "VU" },
                new Country { Id = cnt++, FullName = "Vatican", Code = "VA" },
                new Country { Id = cnt++, FullName = "Venezuela", Code = "VE" },
                new Country { Id = cnt++, FullName = "Vietnam", Code = "VN" },
                new Country { Id = cnt++, FullName = "Wallis and Futuna Isls", Code = "WF" },
                new Country { Id = cnt++, FullName = "Western Sahara", Code = "EH" },
                new Country { Id = cnt++, FullName = "Yemen", Code = "YE" },
                new Country { Id = cnt++, FullName = "Zaire", Code = "ZR" },
                new Country { Id = cnt++, FullName = "Zambia", Code = "ZM" },
                new Country { Id = cnt++, FullName = "Zimbabwe", Code = "ZW" });
        }
    }
}