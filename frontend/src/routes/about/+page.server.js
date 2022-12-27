/** @type {import('./$types').PageServerLoad} */
import { SECRET_API_URL } from '$env/static/private';


export async function load({ fetch, params }) {

    const res = await fetch(`${SECRET_API_URL}/weather-types`);
    const items = await res.json();
   
    return { items };
  }