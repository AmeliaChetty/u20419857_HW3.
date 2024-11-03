const express = require('express');
const bodyParser = require('body-parser');
const cors = require('cors');
const app = express();
const port = 3000;

app.use(cors());
app.use(bodyParser.json());

let students = [];
let books = [];

app.get('/api/students', (req, res) => {
    res.json(students);
});

app.post('/api/students', (req, res) => {
    const student = { id: students.length + 1, ...req.body };
    students.push(student);
    res.status(201).json(student);
});

app.get('/api/books', (req, res) => {
    const booksWithStatus = books.map
