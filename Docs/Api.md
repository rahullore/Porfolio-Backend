#Portfolio API
- [Login](#login)
- [Login Request](#login-request)
- [Login Response](#login-response)

##Auth

### Login

```js
POST {{host}}/auth/login
```
### Login Request
```json
{
    "email":"rahullore@gmail.com,
    "password":"pass@word"
}

```
### Login Response

```js
200 OK
```

```json
{
    "Id":"New Guid",
    "firstName":"Rahul",
    "lastName":"Lore",
    "email":"rahullore@gmail.com",
    "token":"token"
}