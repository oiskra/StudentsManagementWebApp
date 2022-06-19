const student = document.getElementById("student")
const wykladowca = document.getElementById("wykladowca")

console.log(wykladowca)

wykladowca.addEventListener("click", () => {
    student.classList.remove("active")
    wykladowca.classList.add("active")
    console.log("wykladowca: " + wykladowca)
})

    student.addEventListener("click",()=> {
        student.classList.remove("active")
        wykladowca.classList.add("active")
        console.log(student.className)
    console.log("student: " + student)
})

