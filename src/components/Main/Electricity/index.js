export default () => (
  <div>
    <h3>This is the electricity form</h3>
    <form onSubmit='undefined'>
      <input type='hidden' value='electricity' />
      <input type='hidden' value='mwh' />
      <label htmlFor='electricity_value'>Electricity usage (in MWh):
        <input name='electricity_value' type='number' />
      </label>
      <label htmlFor='country'>Country:
        <select name='country' placeholder='United States'>
          <option value='us'>United States</option>
        </select>
      </label>
      <label htmlFor='state'>State:
        <select name='state' placeholder='Oregon'>
          <option value='or'>Oregon</option>
        </select>
      </label>
      <button type='submit'>Estimate</button>
    </form>
  </div>
)
