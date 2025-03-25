window.bootstrapInit = () => {
    document.querySelectorAll('[data-bs-toggle="collapse"]').forEach(el => {
        el.addEventListener('click', e => {
            e.preventDefault();
            let target = el.getAttribute('data-bs-target');
            if (target) {
                let element = document.querySelector(target);
                if (element) {
                    new bootstrap.Collapse(element);
                }
            }
        });
    });
};
