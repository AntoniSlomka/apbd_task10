Anwsers to questions:
1. Because database isn't secure enough to store raw values of passwords 
and anyone with access to it could use the information to access user's accounts.
2. Because SHA-256 is easily brute-forcable and susceptible to rainbow table attacks.
3. We use salt so that two different users with the same password will produce different hashes.
4. Salt is random, unique per user, and stored alongside the hash whereas pepper is a secret value 
shared across all passwords, stored separately.
5. Authentication is verifying who you are and authorization is verifying what you're allowed to do.
6. A user can still call the URL directly.
7. It reveals that the usernames exists in the system, which helps attackers gain 
information about valid accounts.