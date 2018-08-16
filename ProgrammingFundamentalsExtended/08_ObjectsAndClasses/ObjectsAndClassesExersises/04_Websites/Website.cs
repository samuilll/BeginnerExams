using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Website
    {
    public string Host { get; set; }

    public string Domain { get; set; }

    public List<string> Queries { get; set; }

    public static Website Parse(string input)
    {
        var site = new Website();

        var separateInput = input
            .Split(new char[] { ' ','|' }, StringSplitOptions.RemoveEmptyEntries)
            .ToList();

        site.Host = separateInput[0];

        site.Domain = separateInput[1];

        if (separateInput.Count>2)
        {
            var queries = separateInput[2].Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            site.Queries = queries;
        }

        return site;
    }
}

