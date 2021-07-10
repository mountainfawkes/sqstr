export default () => (
  <div>
    <h3>This is the flight form</h3>
    <form onSubmit='undefined'>
      <input type='hidden' value='flight' />
      <label htmlFor='passengers'>Number of passengers:
        <input name='passengers' type='number' />
      </label>
      <label htmlFor='departure-airport'>Departure airport:
        <select name='departure-airport'>
          <option value='pdx'>PDX - Portland International Airport</option>
        </select>
      </label>
      <label htmlFor='destination-airport'>Destination airport:
        <select name='destination-airport'>
          <option value='sfo'>SFO - San Francisco International Airport</option>
        </select>
      </label>
      <button type='submit'>Estimate</button>
    </form>
  </div>
)
