package com.example.filmbrosproject.data

//REPOSITORIO QUE TRATE CON EL VIEWMODEL

class UserRepository(private val userDao: UserDao) {
    suspend fun login(username: String, pass: String): Boolean {
        val user = userDao.getUserByUsername(username)
        return user != null && user.password == pass
    }

    suspend fun register(username: String, pass: String) {
        userDao.registerUser(User(username, pass))
    }

    suspend fun getUser(name: String) = userDao.getUserByUsername(name)

    suspend fun updateUser(user: User) {
        userDao.updateUser(user)
    }
}