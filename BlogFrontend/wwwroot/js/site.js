function showModal(modalId) {
    document.getElementById(modalId).style.display = 'block';
}

function closeModal(modalId) {
    document.getElementById(modalId).style.display = 'none';
}

async function getFormData(formData) {
    const form = document.querySelector('.addBlogForm');
    for (const [key, value] of new FormData(form)) {
        formData.append(key, value);
    }
}
