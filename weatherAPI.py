import httplib2
import json

h = httplib2.Http(".cache")
resp, content = h.request("http://api.wunderground.com/api/d02a6cf19dda700f/geolookup/conditions/q/CA/Carmichael.json", "GET")
parsed_json = json.loads(content)
location = parsed_json['location']['city']
temp_c = parsed_json['current_observation']['temp_c']
print "Current temperature in %s is: %s C" % (location, temp_c)
