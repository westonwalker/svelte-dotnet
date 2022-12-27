<script>
    /** @type {import('./$types').PageData} */
    export let data;
  </script>

<svelte:head>
    <title>About</title>
</svelte:head>

<h1>About this site</h1>
<ul>
	{#each data.items as item}
        <li>{item}</li>
	{/each}
</ul>
<a href="/">Home</a>