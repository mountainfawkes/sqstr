sqstr: Project Proposal

Name of Student: Jonathan Stull

Name of Project: sqstr

Project's Purpose or Goal:

Right now, there is an emerging market for carbon-based cryptocurrency and an urgent climate crisis. While the emphasis of solutions should be placed on collective action by our largest institutions (ahem, corporations), there does not currently exist a consumer-level service that can estimate individual carbon emissions and recommend direct action in the form of carbon-based token investments.

Sqstr will change that by providing an engine that recommends the amount of carbon tokens an individual should buy based on their individual level of carbon emissions.

This tool will gather user input required to query an API that responds with a carbon estimate in tonnes backed by a science-based and peer-reviewed methodology. This figure will be cross-referenced with another API that responds with the current value of the UPCO2 carbon-based token (currently hovering around $9.50 per tonne).


List the absolute minimum features the project requires to meet this purpose or goal:

Gather user input to complete a POST request to the carbon emissions estimate API
Cross-reference carbon emissions in metric tonnes with the current value of UPCO2, a carbon-based token
Return this information to the user and provide investment resources to facilitate action

What tools, frameworks, libraries, APIs, modules and/or other resources (whatever is specific to your track, and your language) will you use to create this MVP? List them all here. Be specific.

APIs
Carbon Interface: API tool to build a profile of carbon emissions in categories of electricity consumption, travel (by car and by plane), and a handful of other categories to return a carbon emissions value in metric tonnes
Nomics: a free cryptocurrency API that includes a price listing for UPCO2
Front end:
React with Redux
jQuery
Bootstrap
Back end:
C#/.NET Entity Framework Core to handle server interaction
Firebase or Heroku to store data in a cloud-based server

If you finish developing the minimum viable product (MVP) with time to spare, what will you work on next? Describe these features here: Be specific.

Data aggregation
Possible administrator-level data analysis, where user data is aggregated to show emissions trends over time (I think this is where there is real value)
User registration and authentication
Historical emissions trends
Aggregate emissions totals
Other user-centric data and reports
Integration with Uphold (UPCO2’s parent exchange) to facilitate trade orders for UPCO2

What additional tools, frameworks, libraries, APIs, or other resources will these additional features require?

JWT: User registration and authentication
Uphold Open API: a resource to facilitate buy and sell orders of UPCO2
oAuth: required for authentication with the Uphold Open API

Is there anything else you'd like your instructor to know?

I’m excited to take on this project and show what I can do!
